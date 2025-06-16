using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class CimDTO : BaseDTO
    {
        private long? _ID = null;
        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _OrszagKod = null;
        public string OrszagKod
        {
            get { return _OrszagKod; }
            set { _OrszagKod = value; }
        }

        private string _OrszagNev = null;
        public string OrszagNev
        {
            get { return _OrszagNev; }
            set { _OrszagNev = value; }
        }

        private string _Allam = null;
        public string Allam
        {
            get { return _Allam; }
            set { _Allam = value; }
        }

        private long? _MegyeID = null;
        public long? MegyeID
        {
            get { return _MegyeID; }
            set { _MegyeID = value; }
        }

        private string _MegyeKod;
        public string MegyeKod
        {
            get { return _MegyeKod; }
            set { _MegyeKod = value; }
        }	

        private string _Telepules = null;
        public string Telepules
        {
            get { return _Telepules; }
            set { _Telepules = value; }
        }

        private string _Kerulet = null;
        public string Kerulet
        {
            get { return _Kerulet; }
            set { _Kerulet = value; }
        }

        private string _Kozterulet = null;
        public string Kozterulet
        {
            get { return _Kozterulet; }
            set { _Kozterulet = value; }
        }

        private string _Hazszam = null;
        public string Hazszam
        {
            get { return _Hazszam; }
            set { _Hazszam = value; }
        }

        private string _EmeletAjto = null;
        public string EmeletAjto
        {
            get { return _EmeletAjto; }
            set { _EmeletAjto = value; }
        }

        private string _Iranyitoszam = null;
        public string Iranyitoszam
        {
            get { return _Iranyitoszam; }
            set { _Iranyitoszam = value; }
        }

        public string TeljesCim
        {
            get {
				string s = null;
                if (!string.IsNullOrEmpty(Iranyitoszam) || !string.IsNullOrEmpty(Telepules))
                {
                    if (!string.IsNullOrEmpty(Kozterulet))
                        s = Iranyitoszam + " " + Telepules + ", " + " " + Kerulet + " " + Kozterulet + " " + Hazszam + " " + EmeletAjto;
                    else s = Iranyitoszam + " " + Telepules;
                }
                else s = Kerulet + " " + Kozterulet + " " + Hazszam + " " + EmeletAjto;
				return s.Trim();
            }
        }

        public string UtcaHazszam
        {
            get
            {
                string s = Kerulet + " " + Kozterulet + " " + Hazszam + " " + EmeletAjto;
                return s.Trim();
            }
        }
    }

    [Serializable]
    public class CimKeresoDTO : CimDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private bool _ToroltekIs = false;

        public bool ToroltekIs
        {
            get { return _ToroltekIs; }
            set { _ToroltekIs = value; }
        }

        private bool _CsakToroltek = false;

        public bool CsakToroltek
        {
            get { return _CsakToroltek; }
            set { _CsakToroltek = value; }
        }

        private DateTime? _RogzDatumKezdete = null;

        public DateTime? RogzDatumKezdete
        {
            get { return _RogzDatumKezdete; }
            set { _RogzDatumKezdete = value; }
        }
        private DateTime? _RogzDatumVege = null;

        public DateTime? RogzDatumVege
        {
            get { return _RogzDatumVege; }
            set { _RogzDatumVege = value; }
        }
        private DateTime? _ModDatumKezdete = null;

        public DateTime? ModDatumKezdete
        {
            get { return _ModDatumKezdete; }
            set { _ModDatumKezdete = value; }
        }
        private DateTime? _ModDatumVege = null;

        public DateTime? ModDatumVege
        {
            get { return _ModDatumVege; }
            set { _ModDatumVege = value; }
        }
        private DateTime? _TorlDatumKezdete = null;

        public DateTime? TorlDatumKezdete
        {
            get { return _TorlDatumKezdete; }
            set { _TorlDatumKezdete = value; }
        }
        private DateTime? _TorlDatumVege = null;

        public DateTime? TorlDatumVege
        {
            get { return _TorlDatumVege; }
            set { _TorlDatumVege = value; }
        }
    }
}
