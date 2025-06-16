using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Reflection;
using AquaSoft.Framework.Runtime;
using AquaSoft.Framework.Util;

namespace AquaSoft.Sentinel2.DTO
{
    public class PageConfig : BaseConfiguration
    {
        [XmlElement("Control")]
        public List<ControlConfig> ControlConfigList;

		[XmlElement("Setting")]
		public List<SettingConfig> SettingConfigList;

        [XmlIgnore]
        public SortedList<string, SortedList<string, object>> ControlList
        {
            get
            {
                SortedList<string, SortedList<string, object>> result = new SortedList<string, SortedList<string, object>>();
                foreach (ControlConfig cc in ControlConfigList)
                {
                    SortedList<string, object> AttributeList = new SortedList<string, object>();
                    result[cc.Name] = AttributeList;
                    foreach (AttributeConfig ac in cc.AttributeConfigList)
                        AttributeList[ac.Name] = GlobalUtils.CreateSimpleObject(ac.Type, ac.Value);
                }
                return result;
            }
        }

        public void Merge(PageConfig OLDPageConfig)
        {
            List<ControlConfig> OLDs = new List<ControlConfig>();
            foreach (ControlConfig OLDcontrol in OLDPageConfig.ControlConfigList)
            {
                bool BenneVan = false;
                foreach (ControlConfig control in this.ControlConfigList)
                    if (control.Name == OLDcontrol.Name)
                    {
                        BenneVan = true;
                        control.Merge(OLDcontrol);
                        break;
                    }
                if (!BenneVan)
                    OLDs.Add(OLDcontrol);
            }
            this.ControlConfigList.AddRange(OLDs);

			List<SettingConfig> OLDss = new List<SettingConfig>();
			foreach (SettingConfig OLDsetting in OLDPageConfig.SettingConfigList)
			{
				bool BenneVan = false;
				foreach (SettingConfig setting in this.SettingConfigList)
					if (setting.Name == OLDsetting.Name)
					{
						BenneVan = true;
						break;
					}
				if (!BenneVan) OLDss.Add(OLDsetting);
			}
			this.SettingConfigList.AddRange(OLDss);
        }
    }

    public class ControlConfig
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlElement("Attribute")]
        public List<AttributeConfig> AttributeConfigList;

        public void Merge(ControlConfig OLDControl)
        {
            List<AttributeConfig> OLDs = new List<AttributeConfig>();
            foreach (AttributeConfig OLDattribute in OLDControl.AttributeConfigList)
            {
                bool BenneVan = false;
                foreach (AttributeConfig attribute in this.AttributeConfigList)
                    if (attribute.Name == OLDattribute.Name)
                    {
                        BenneVan = true;
                        break;
                    }
                if (!BenneVan)
                    OLDs.Add(OLDattribute);
            }
            this.AttributeConfigList.AddRange(OLDs);
        }
    }

	public class SettingConfig
	{
		[XmlAttribute("name")]
		public string Name;

		[XmlAttribute("value")]
		public string Value;
	}

    public class AttributeConfig
    {
        [XmlAttribute("name")]
        public string Name;
        [XmlAttribute("type")]
        public string Type;
        [XmlAttribute("value")]
        public string Value;
    }
}
