using log4net; using System; 
using System.Collections.Generic;
using System.Text;
using AquaSoft.Sentinel2.DTO;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class HataridoNaploDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private DateTime? _EsemenyKezdete = null;

        public DateTime? EsemenyKezdete
        {
            get { return _EsemenyKezdete; }
            set { _EsemenyKezdete = value; }
        }

        private DateTime? _EsemenyVege = null;

        public DateTime? EsemenyVege
        {
            get { return _EsemenyVege; }
            set { _EsemenyVege = value; }
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

        private string _EsemenyKod = null;

        public string EsemenyKod
        {
            get { return _EsemenyKod; }
            set { _EsemenyKod = value; }
        }

        private string _EsemenyLeiras = null;

        public string EsemenyLeiras
        {
            get { return _EsemenyLeiras; }
            set { _EsemenyLeiras = value; }
        }

        private string _EsemenyNev = null;

        public string EsemenyNev
        {
            get { return _EsemenyNev; }
            set { _EsemenyNev = value; }
        }

        private string _TipusKod = null;

        public string TipusKod
        {
            get { return _TipusKod; }
            set { _TipusKod = value; }
        }

        public string TipusNev
        {
            get { return DTOSzotar.Nev(Nyelv, "HATARIDONAPLO", TipusKod); }
        }

        private String _TorlNev;

        public String TorlNev
        {
            get { return _TorlNev; }
            set { _TorlNev = value; }
        }

    }
    [Serializable]
    public class HataridoNaploKeresoDTO : HataridoNaploDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private DateTime? _EsemenyDatuma = null;

        public DateTime? EsemenyDatuma
        {
            get { return _EsemenyDatuma; }
            set { _EsemenyDatuma = value; }
        }

        private DateTime? _Datumtol = null;

        public DateTime? Datumtol
        {
            get { return _Datumtol; }
            set { _Datumtol = value; }
        }

        private DateTime? _Datumig = null;

        public DateTime? Datumig
        {
            get { return _Datumig; }
            set { _Datumig = value; }
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

		private DateTime? _AtfedesKezdete = null;
		public DateTime? AtfedesKezdete
		{
			get { return _AtfedesKezdete; }
			set { _AtfedesKezdete = value; }
		}

		private DateTime? _AtfedesVege = null;
		public DateTime? AtfedesVege
		{
			get { return _AtfedesVege; }
			set { _AtfedesVege = value; }
		}

    }

}
