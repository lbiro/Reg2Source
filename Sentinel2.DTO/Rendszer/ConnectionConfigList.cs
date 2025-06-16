using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using AquaSoft.Framework.Runtime;

namespace AquaSoft.Sentinel2.DTO
{
    public class ConnectionConfigList : BaseConfiguration
    {
        private List<ConnectionConfig> _ConnList;

        public List<ConnectionConfig> ConnList
        {
            get { return _ConnList; }
            set { _ConnList = value; }
        }

        public ConnectionConfig GetConnectionByName(string ConnectionName)
        {
            foreach (ConnectionConfig cc in ConnList)
                if (cc.Name == ConnectionName)
                    return cc;
            return null;
        }

        public void Merge(ConnectionConfigList OLDConnList)
        {
            foreach (ConnectionConfig OLDcc in OLDConnList.ConnList)
            {
                ConnectionConfig NEWcc = GetConnectionByName(OLDcc.Name);
                if (NEWcc == null)
                    ConnList.Add(OLDcc);
            }
        }
    }

    public class ConnectionConfig
    {
        private string _Name;
        [XmlAttribute(AttributeName = "name")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Type;
        [XmlAttribute(AttributeName = "type")]
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _ConnectionString;
        [XmlAttribute(AttributeName = "connectionstring")]
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

		//private string _CommandTimeout;
		//[XmlAttribute(AttributeName = "commandtimeout")]
		//public string CommandTimeout
		//{
		//    get { return _CommandTimeout; }
		//    set { _CommandTimeout = value; }
		//}
    }
}
