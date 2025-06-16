using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class SzabalyTokenDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _SzabalyID = null;

        public long? SzabalyID
        {
            get { return _SzabalyID; }
            set { _SzabalyID = value; }
        }

        private string _NapTipusKod = null;

        public string NapTipusKod
        {
            get { return _NapTipusKod; }
            set { _NapTipusKod = value; }
        }

        public string NapTipusNev
        {
            get { return DTOSzotar.Nev(Nyelv, "NAPTIPUS", NapTipusKod); }
        }

        private string _KezdoIdopont = null;

        public string KezdoIdopont
        {
            get { return _KezdoIdopont; }
            set { _KezdoIdopont = value; }
        }

        private string _BefejezoIdopont = null;

        public string BefejezoIdopont
        {
            get { return _BefejezoIdopont; }
            set { _BefejezoIdopont = value; }
        }

        public string IdoIntervallum
        {
            get { return (KezdoIdopont != null ? KezdoIdopont : "00:00") + "-" + (BefejezoIdopont != null ? BefejezoIdopont : "23:59"); }
        }

        private string _Finanszirozas = null;

        public string Finanszirozas
        {
            get { return _Finanszirozas; }
            set { _Finanszirozas = value; }
        }

        public bool Elojegyezheto { get; set; }
    }

    [Serializable]
    public class SzabalyTokenKeresoDTO : SzabalyTokenDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }
    }
}
