<%@ Application Language="C#" %>
<%@ Import Namespace="AquaSoft.Framework.Runtime" %>
<%@ Import Namespace="AquaSoft.Framework.Web.Runtime" %>

<script RunAt="server">

    
	void Application_Start(object sender, EventArgs e)
	{
		Initiator.ApplicationInit(Context);
	}

	void Application_End(object sender, EventArgs e)
	{
		//  Code that runs on application shutdown

	}

	void Application_Error(object sender, EventArgs e)
	{

		Exception ex = Server.GetLastError();
		if (ex.InnerException != null)
		{
			new WebMunkamenet(Context)["InnerException"] = ex.InnerException.ToString();
		}
		else
		{
			new WebMunkamenet(Context)["InnerException"] = null;
		}			
		new WebMunkamenet(Context)["Exception"] = ex.ToString();
		
		//Logba mentés
		log4net.ILog log = log4net.LogManager.GetLogger("AquaSoft.Sentinel2.WebApp");
		WebApplicationManager.Logger = log;
		log.Error("Login nev: "+ (HttpContext.Current.Session["LOGINNEV"] != null ? HttpContext.Current.Session["LOGINNEV"] : "NULL") +" Alkalmazás hiba történt: " + ex.ToString());
		
		
		if (ApplicationManager.Config.GetBool("RendszerExceptionKezeles"))
		{
			log.Error("Exception küldés kezdése.");
			/*HttpApplication application = (HttpApplication)sender;
			HttpContext context = application.Context;
			HttpSessionState s = application.Context.Session;
			s["ex"] = ex.InnerException.ToString();
                    
			HttpApplication httpApp =  HttpContext.Current.ApplicationInstance;
			HttpModuleCollection httpModuleColl = httpApp.Modules;
			httpApp.Session["Exception"] = ex.ToString();*/


			string RootLink = ApplicationManager.Config.GetString("RootLink");
			//ErrorPage-ről ErrorPage-re nem ugrunk
			log.Error("ErrorPage keresés.");
			log.Error("Page:" + Request.Url.Segments[Request.Url.Segments.GetUpperBound(0)].ToString());
			if (Request.Url.Segments[Request.Url.Segments.GetUpperBound(0)] != "ErrorPage.aspx")
			{
				Context.ClearError();
				//ha az exceptiont kiváltó oldal dialógusablak, akkor bezárjuk, és a szülőablakot irányítjuk az errorpage-re
				//if (Context.Handler.GetType().IsSubclassOf(System.Type.GetType("sentinel.WebApp.classes.ModalPage")))
				//{
				//        //ezt egyelőre kihagyjuk
				//}
				//else
				//{

				//nem dialógusablak...                            				
                log.Error("Küldés az ErroPage-re: " + RootLink + "Forms/Altalanos/Rendszer/ErrorPage.aspx?NoMenu=true");
				Context.Response.Redirect(RootLink + "Forms/Altalanos/Rendszer/ErrorPage.aspx?NoMenu=true", true);
				//Context.Server.Transfer(RootLink + "Forms/Altalanos/Rendszer/ErrorPage.aspx?NoMenu=true");
				//}
			}
		}
	}

	void Session_Start(object sender, EventArgs e)
	{
		//Initiator.ApplicationInit(Context);
	}

	void Session_End(object sender, EventArgs e)
	{
		// Code that runs when a session ends. 
		// Note: The Session_End event is raised only when the sessionstate mode
		// is set to InProc in the Web.config file. If session mode is set to StateServer 
		// or SQLServer, the event is not raised.

	}
       
</script>

