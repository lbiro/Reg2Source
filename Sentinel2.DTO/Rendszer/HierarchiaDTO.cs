using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class HierarchiaDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Kod = null;

        public string Kod
        {
            get { return _Kod; }
            set { _Kod = value; }
        }

        private string _KodNev = null;

        public string KodNev
        {
            get { return _KodNev; }
            set { _KodNev = value; }
        }

        private string _Szint = null;

        public string Szint
        {
            get { return _Szint; }
            set { _Szint = value; }
        }

        private string _Cimke = null;

        public string Cimke
        {
            get { return _Cimke; }
            set { _Cimke = value; }
        }

        private string _TeljesCimke;

        public string TeljesCimke
        {
            get { return _TeljesCimke; }
            set { _TeljesCimke = value; }
        }

        private long? _ObjektumID = null;

        public long? ObjektumID
        {
            get { return _ObjektumID; }
            set { _ObjektumID = value; }
        }
    }

    [Serializable]
    public class HierarchiaKeresoDTO : HierarchiaDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _SzintMinta = null;

        public string SzintMinta
        {
            get { return _SzintMinta; }
            set { _SzintMinta = value; }
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
