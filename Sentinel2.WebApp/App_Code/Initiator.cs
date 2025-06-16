using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using AquaSoft.Framework.Runtime;
using AquaSoft.Framework.Util;
using AquaSoft.Framework.Web.Runtime;
using AquaSoft.Sentinel2.BusinessLogic;
using AquaSoft.Sentinel2.DAO.Factory;
using AquaSoft.Sentinel2.DTO;
using log4net;

public class Initiator
{
	private static ILog log;
	private static HttpContext Context;

	public Initiator()
	{
	}

	public static void ApplicationInit(HttpContext Contextp)
	{
		try
		{
			ApplicationManager.Config.Clear();

			Context = Contextp;
			//Logger Config
			System.IO.FileInfo fi = new System.IO.FileInfo(Context.Request.MapPath("~/Config/log4net.config"));
			log4net.Config.XmlConfigurator.Configure(fi);
			log = LogManager.GetLogger("AquaSoft.Sentinel2.WebApp");
			//az alkalmazás log bárhonnan elérhető
			WebApplicationManager.Logger = log;
			log.Info("Logger elindítva");

			/*
			 * a config állományokat az alábbiak szerint kell beolvasni:
			 * 1. application-config.xml - ez az általános konfig állomány
			 * 2. machine-<gépnév>-config.xml - alkalmazás-szerver specifikus konfig állomány (specifikus, gépet és esetlegesen működést érintő konfig)
			 * 3. pageconfig.xml - általános oldal szintű konfigurálást biztosító állomány
			 * 4. <projekt>-config.xml - a projekt specifikus konfig állomány (üzleti logikát érintő konfig)
			 * 5. szolgaltatasok-<projekt>.xml - projektekben a szolgáltatások (pl. Sentinel, AquaPrint, stb) elérése
			 * 6. application-<projekt>-pageconfig.xml - projekt specifikus oldal szintű konfigurálást biztosító állomány
			 * 7. dev-<gépnév>.xml - saját fejlesztői beállítások (nem kötelező), amiket a végén kell átállítani és ezért nem mehet a machine configba
			 * 
			 * */

			xmlLoad();
			lokalizacioLoad();
			oldalLoad();
			szotarLoad();
			tablakElotoltese();

			if (!ApplicationManager.Config.ContainsConfig("RegLite") || !ApplicationManager.Config.GetBool("RegLite"))
			{
				//Az előjegyzés tábla felépítése a memóriába
				Elojegyzes.UtkozoElojegyzesLista.Clear();				
				DateTime KezdesDatum = DateTime.Now.Date;
				if (ApplicationManager.Config.ContainsConfig("ElojegyezhetoIntervallumHosszMultba") 
					&& ApplicationManager.Config.GetInt("ElojegyezhetoIntervallumHosszMultba") > 0)
					KezdesDatum = KezdesDatum.AddMonths(-(ApplicationManager.Config.GetInt("ElojegyezhetoIntervallumHosszMultba"))).AddSeconds(-1);
				
				Elojegyzes.Init(KezdesDatum, DateTime.Today.AddMonths(ApplicationManager.Config.GetInt("ElojegyezhetoIntervallumHossz")).AddSeconds(-1));
			}
		}
		catch (Exception ex)
		{
			ApplicationManager.Config.Insert("INITERROR", ex);
			if (WebApplicationManager.Logger != null)
				WebApplicationManager.Logger.Fatal("Initiator error: ", ex);
			//Context.Server.Transfer("~/Forms/Altalanos/Rendszer/InitError.aspx", false);
			//Context.Response.Redirect("~/Forms/Altalanos/Rendszer/InitError.aspx", true);
		}
	}

	public static void xmlLoad()
	{
		log.Info("Konfig XML-ek betöltése megkezdődött");
		ApplicationManager.Config.ClearButKeep("CACHE_");

		string baseDir = "Config/Configuration/";

		// 1. általános config (kötelező)
		if (!xmlLoadLoad(baseDir + "application-config.xml", "string"))
		{
			log.Fatal("Hiányzik: application-config.xml");
			throw new Exception("Hiányzik: application-config.xml");
		}

		// 2. gép config (kötelező)
		String GepNev = Environment.MachineName.ToLower();
		if (!xmlLoadLoad(baseDir + "machine-" + GepNev + "-config.xml", "string"))
		{
			if (!xmlLoadLoad(baseDir + "machine-" + GepNev + ".xml", "string"))
			{
				log.Fatal("Hiányzik: machine-" + GepNev + "[-config].xml");
				throw new Exception("Hiányzik: machine-" + GepNev + "[-config].xml");
			}
		}

		factoryLoad();

		// fürdőcsoportok (alkalmazás, projekt, akármi gyűjtőnév) betöltése

		// 3. általános pageconfig (opcionális)
		xmlLoadLoad(baseDir + "pageconfig.xml", "AquaSoft.Sentinel2.DTO.PageConfig,AquaSoft.Sentinel2.DTO");

		string ProjektID = ApplicationManager.Config.GetString("ProjektID");

		// 4. projekt config (kötelező)
		if (!xmlLoadLoad(baseDir + "projekt-" + ProjektID + "-config.xml", "string"))
		{
			if (!xmlLoadLoad(baseDir + "projekt-" + ProjektID + ".xml", "string"))
			{
				log.Fatal("Hiányzik: projekt-" + ProjektID + "[-config].xml");
				throw new Exception("Hiányzik: projekt-" + ProjektID + "[-config].xml");
			}
		}

		// 5. projekt szolgáltatás config (opcionális)
		xmlLoadLoad(baseDir + "szolgaltatasok-" + ProjektID + ".xml", "string");

		// 6. projekt pageconfig ((már nem) kötelező)
		if (!xmlLoadLoad(baseDir + "application-" + ProjektID + "-pageconfig.xml", "AquaSoft.Sentinel2.DTO.PageConfig,AquaSoft.Sentinel2.DTO"))
		{
			if (!xmlLoadLoad(baseDir + "pageconfig-" + ProjektID + ".xml", "AquaSoft.Sentinel2.DTO.PageConfig,AquaSoft.Sentinel2.DTO"))
			{
				//log.Fatal("Hiányzik: application- " + ProjektID + " -pageconfig.xml");
				//throw new Exception("Hiányzik: application-" + ProjektID + " -pageconfig.xml");
			}
		}

		// 7. fejlesztői config (opcionális)
		xmlLoadLoad(baseDir + "dev-" + GepNev + ".xml", "string");

		log.Info("Konfig XML-ek betöltése befejeződött");
	}

	private static bool xmlLoadLoad(string file, string DefaultType)
	{
		file = Context.Request.MapPath("~/" + file);
		if (!System.IO.File.Exists(file)) return false;
		ApplicationManager.Config.Betolt(file, DefaultType);
		return true;
	}

	public static void factoryLoad()
	{
		log.Info("Factory.Init megkezdődött");

		ConnectionConfig ConnConf = ((ConnectionConfigList)ApplicationManager.Config.GetObject("DBConnentions")).GetConnectionByName("DBMS");
		RendszerFactory.Init(ConnConf.Type, ConnConf.ConnectionString);
		ErtekesitesFactory.Init(ConnConf.Type, ConnConf.ConnectionString);
		RegiszterFactory.Init(ConnConf.Type, ConnConf.ConnectionString);

		log.Info("Factory.Init befejeződött");
	}

	public static void lokalizacioLoad()
	{
		LocalizationManager.Clear();

		log.Info("Lokalizáció betöltése megkezdődött");
		String ProjektID = ApplicationManager.Config.GetString("ProjektID");

		LocalizationManager.AddCulture("hu-HU");
		LocalizationManager.AddCulture("en-US");
		LocalizationManager.AddCulture("ge-GE");
		LocalizationManager.AddCulture("li-LI");
		LocalizationManager.AddCulture("ro-RO");

		lokalizacioLoadLoad("Config/Localization/hu-HU.xml", "hu-HU", "");
		lokalizacioLoadLoad("Config/Localization/hu-HU-Altalanos.Beleptetes.xml", "hu-HU", "Altalanos.Beleptetes.");
		lokalizacioLoadLoad("Config/Localization/hu-HU-Altalanos.Ertekesites.xml", "hu-HU", "Altalanos.Ertekesites.");
		lokalizacioLoadLoad("Config/Localization/hu-HU-Altalanos.Regiszter.xml", "hu-HU", "Altalanos.Regiszter.");
		lokalizacioLoadLoad("Config/Localization/hu-HU-" + ProjektID + "-Altalanos.Regiszter.xml", "hu-HU", "Altalanos.Regiszter.");
		lokalizacioLoadLoad("Config/Localization/hu-HU-Altalanos.Rendszer.xml", "hu-HU", "Altalanos.Rendszer.");
		lokalizacioLoadLoad("Config/Localization/hu-HU-" + ProjektID + "-Altalanos.Rendszer.xml", "hu-HU", "Altalanos.Rendszer.");
		//Dokumentáció
		//Gyor
		lokalizacioLoadLoad("Config/Localization/hu-HU-Gyor.Regiszter.xml", "hu-HU", "Gyor.Regiszter.");

		lokalizacioLoadLoad("Config/Localization/hu-HU-Altalanos.Logisztika.xml", "hu-HU", "Altalanos.Logisztika.");
		lokalizacioLoadLoad("Config/Localization/hu-HU-Konfigurator.xml", "hu-HU", "Konfigurator.");

		lokalizacioLoadLoad("Config/Localization/en-US-Altalanos.Regiszter.xml", "en-US", "Altalanos.Regiszter.");
		lokalizacioLoadLoad("Config/Localization/ge-GE-Altalanos.Regiszter.xml", "ge-GE", "Altalanos.Regiszter.");
		lokalizacioLoadLoad("Config/Localization/li-LI-Altalanos.Regiszter.xml", "li-LI", "Altalanos.Regiszter.");
		lokalizacioLoadLoad("Config/Localization/ro-RO-Altalanos.Regiszter.xml", "ro-RO", "Altalanos.Regiszter.");

		LocalizationManager.Culture = "hu-HU";
		log.Info("Lokalizáció betöltése befejeződött");
	}

	private static bool lokalizacioLoadLoad(string file, string nyelv, string prefix)
	{
		file = Context.Request.MapPath("~/" + file);
		if (!File.Exists(file)) return false;
		LocalizationManager.AddLocalization(nyelv, prefix, new ExtendedHashtable(file, "Localization"));
		return true;
	}

	public static void oldalLoad()
	{
		log.Info("Oldalak betöltése megkezdődött");

		string RootLink = ApplicationManager.Config.GetString("RootLink");
		foreach (OldalDTO oldal in Oldal.Lekerdez(new OldalKeresoDTO(), null))
			WebApplicationManager.Navigation.Add(oldal.FormID, RootLink + oldal.URL, oldal.URLParameterek, oldal.MunkamenetParameterek);

		log.Info("Oldalak betöltése befejeződött");
	}

	public static void szotarLoad()
	{
		log.Info("Szótár betöltés megkezdődött");

		//Szótár felolvasás
		SzotarKeresoDTO szdto = new SzotarKeresoDTO();
		szdto.Nyelv = "hu";
		DTOSzotar.Init(Szotar.Lekerdez(szdto, null));
		//szdto.NyelvKod = "en";
		//DTOSzotar.Init("en", Szotar.Lekerdez(szdto, null));
		//szdto.NyelvKod = "ge";
		//DTOSzotar.Init("ge", Szotar.Lekerdez(szdto, null));

		//Fordítás felolvasás
		ForditasKeresoDTO fdto = new ForditasKeresoDTO();
		fdto.Nyelv = "hu";
		DTOForditas.Init(Forditas.Lekerdez(fdto, null));
		//fdto.Nyelv = "en";
		//DTOForditas.Init(Forditas.Lekerdez(fdto, null));
		//fdto.Nyelv = "ge";
		//DTOForditas.Init(Forditas.Lekerdez(fdto, null));
		//log.Info("Szótárak betöltve");

		log.Info("Naptár cache indítva");
		Naptar.Kess();
		log.Info("Naptár cache kész");

		log.Info("Initiator.ApplicationInit lefutott");
	}

	public static void ApplicationShutdown()
	{
		ILog log = LogManager.GetLogger("AquaSoft.Sentinel2.WebApp");
		log.Info("Alkalmazás leállítás");
		log.Info("Logger leállítás");
		LogManager.Shutdown();
	}

	public static void cacheKezeloGep()
	{
		// KezeloGep, (SortedList: ID alapján közvetlenül elérhető elemek)
		KezeloGepKeresoDTO kgkdto = new KezeloGepKeresoDTO();
		List<KezeloGepDTO> gepek = KezeloGep.Lekerdez(kgkdto, null);
		SortedList<long?, KezeloGepDTO> slGepek = new SortedList<long?, KezeloGepDTO>();
		foreach (KezeloGepDTO k in gepek) slGepek.Add(k.ID, k);
		ApplicationManager.Config.Insert("CACHE_KezeloGep", slGepek);
	}

	public static void cacheKezelesCsoport()
	{
		// Kezelések Kezelőgép-csoportjai: a kezelés milyen csoportokba tartozik bele
		// A csoport KEZELESCSOPORT Csoport, amihez rendelve vannak a Kezeles-ek
		// fordítva kesseljük: a kezelésekhez tartozó csoportkódok (csoportok) Hashtable-ben.
		SortedList<long?, List<string>> kcsk = new SortedList<long?, List<string>>();
		CsoportKeresoDTO cskdto = new CsoportKeresoDTO();
		cskdto.TipusKod = "KEZELESCSOPORT";
		OsszerendelesKeresoDTO okdto = new OsszerendelesKeresoDTO();
		okdto.TipusKod = "CSOPORTTAGSAG";
		foreach (CsoportDTO cs in Csoport.Lekerdez(cskdto, null))
		{
			okdto.ObjektumID = cs.ID;
			foreach (OsszerendelesDTO o in Osszerendeles.Lekerdez(okdto, null))
			{
				long? kezelesID = o.HozzarendeltID;
				if (kcsk.ContainsKey(kezelesID))
				{
					kcsk[kezelesID].Add(cs.Kod);
				}
				else
				{
					List<string> h = new List<string>();
					h.Add(cs.Kod);
					kcsk[kezelesID] = h;
				}
			}
		}
		ApplicationManager.Config.Insert("CACHE_KezelesKezelesCsoport", kcsk);
	}

	public static void cacheFinanszirozas()
	{
		// Finanszirozas
		FinanszirozasKeresoDTO fkdto = new FinanszirozasKeresoDTO();
		List<FinanszirozasDTO> finansz = Finanszirozas.Lekerdez(fkdto, null);
		foreach (FinanszirozasDTO dto in finansz)
		{
			ApplicationManager.Config.Insert("CACHE_Finanszirozas_" + dto.ID.Value, dto);
		}
	}

	public static void tablakElotoltese()
	{
		ApplicationManager.Config.Clear("CACHE_");

		cacheFinanszirozas();
		cacheKezeloGep();
		cacheKezelesCsoport();

		// Oldalak és szerepkörök: FormID-khoz tartozó szerepkörök (és azok oldaljogkörei)
		if (true)
		{
			SortedList<string, OldalMemoriabanDTO> oszk = new SortedList<string, OldalMemoriabanDTO>();
			SortedList<long?, string> oo = new SortedList<long?, string>();
			OldalSzerepkorokKeresoDTO oszkdto = new OldalSzerepkorokKeresoDTO();
			foreach (OldalSzerepkorokDTO osz in Oldal.SzerepkorLekerdez(oszkdto, null))
			{
				string formid = osz.FormID;
				string szerepkor = osz.SzerepkorKod;
				oo[osz.ID] = formid;
				if (!oszk.ContainsKey(formid))
				{
					OldalMemoriabanDTO om1 = new OldalMemoriabanDTO();
					om1.URL = osz.URL;
					om1.URLParameterek = osz.URLParameterek;
					om1.MunkamenetParameterek = osz.MunkamenetParameterek;
					oszk[formid] = om1;
				}
				OldalMemoriabanDTO om = oszk[formid];
				if (!om.SzerepkorokEsJogkorok.ContainsKey(szerepkor))
				{
					List<string> sj = new List<string>();
					if (osz.OldalJogkor != null && osz.OldalJogkor.Length > 0)
					{
						foreach (string s in osz.OldalJogkor.Trim().Split(','))
						{
							if (s.Trim().Length > 0) sj.Add(s.Trim());
						}
					}
					om.SzerepkorokEsJogkorok[szerepkor] = sj;
				}
			}
			ApplicationManager.Config.Insert("CACHE_OldalSzerepkor", oszk);
			ApplicationManager.Config.Insert("CACHE_OldalOldal", oo);
		}

		// FinanszConfig adatbázisba áttöltése (xml-ből)
		if (true)
		{
			Finanszirozas.FinanszirozasConfigAdatbazisba();
		}

		// Összetartozó kezelések
		if (true)
		{
			SortedList<long?, List<long?>> l = new SortedList<long?, List<long?>>();
			KezelesKeresoDTO kker = new KezelesKeresoDTO();
			List<KezelesDTO> kezelesek = Kezeles.Lekerdez(kker, null);
			for (int i = 0; i < kezelesek.Count; i++)
			{
				KezelesDTO k = kezelesek[i];
				if (string.IsNullOrEmpty(k.TTTKod)) continue;
				for (int j = 0; j < kezelesek.Count; j++)
				{
					if (i != j && k.TTTKod == kezelesek[j].TTTKod)
					{
						if (!l.ContainsKey(k.ID)) l.Add(k.ID, new List<long?>());
						l[k.ID].Add(kezelesek[j].ID);
					}
				}
			}
			ApplicationManager.Config.Insert("CACHE_KezelesKozosHalmaz", l);
		}
		//Több telephely lekérdzés
		/*if (true)
		{
			bool TobbTelephely = false;
			TelephelyKeresoDTO tkdto = new TelephelyKeresoDTO();
			List<TelephelyDTO> t = Telephely.Lekerdez(tkdto, null);
			if (t.Count > 1)
				TobbTelephely = true;

			ApplicationManager.Config.Insert("TobbTelephely", TobbTelephely);
		}*/	
	}
}
