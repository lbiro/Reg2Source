using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class OsszerendelesDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _ObjektumID = null;

        public long? ObjektumID
        {
            get { return _ObjektumID; }
            set { _ObjektumID = value; }
        }

        private long? _HozzarendeltID = null;

        public long? HozzarendeltID
        {
            get { return _HozzarendeltID; }
            set { _HozzarendeltID = value; }
        }

        private string _Ertek = null;

        public string Ertek
        {
            get { return _Ertek; }
            set { _Ertek = value; }
        }

        private string _Ertek2 = null;

        public string Ertek2
        {
            get { return _Ertek2; }
            set { _Ertek2 = value; }
        }

        private DateTime? _ErvenyessegKezdete = null;

        public DateTime? ErvenyessegKezdete
        {
            get { return _ErvenyessegKezdete; }
            set { _ErvenyessegKezdete = value; }
        }

        private DateTime? _ErvenyessegVege = null;

        public DateTime? ErvenyessegVege
        {
            get { return _ErvenyessegVege; }
            set { _ErvenyessegVege = value; }
        }

        private string _TipusKod = null;

        public string TipusKod
        {
            get { return _TipusKod; }
            set { _TipusKod = value; }
        }

        public string TipusNev
        {
            get { return DTOSzotar.Nev(Nyelv, TipusKod, "OSSZERENDELES"); }
        }

        private long? _SzabalyID = null;

        public long? SzabalyID
        {
            get { return _SzabalyID; }
            set { _SzabalyID = value; }
        }

        public String ErvenyessegKezdeteDatum
        {
            get { return (_ErvenyessegKezdete != null) ? _ErvenyessegKezdete.Value.ToShortDateString() : ""; }
            //set { _ErvenyessegKezdeteDatum = value; }
        }

        public String ErvenyessegVegeDatum
        {
            get { return (_ErvenyessegVege!=null) ? _ErvenyessegVege.Value.ToShortDateString() : ""; }
            //set { _ErvenyessegVegeDatum = value; }
        }
    }

    [Serializable]
    public class OsszerendelesKeresoDTO : OsszerendelesDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _ObjektumIDs = null;

        public string ObjektumIDs
        {
            get { return _ObjektumIDs; }
            set { _ObjektumIDs = value; }
        }

        private string _HozzarendeltIDs = null;

        public string HozzarendeltIDs
        {
            get { return _HozzarendeltIDs; }
            set { _HozzarendeltIDs = value; }
        }

        private string _ErtekMinta;

        public string ErtekMinta
        {
            get { return _ErtekMinta; }
            set { _ErtekMinta = value; }
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

        private bool? _UtkozoketListaz;

        public bool? UtkozoketListaz
        {
            get { return _UtkozoketListaz; }
            set { _UtkozoketListaz = value; }
        }

        private DateTime? _ErvenyessegDatuma = null;

        public DateTime? ErvenyessegDatuma
        {
            get { return _ErvenyessegDatuma; }
            set { _ErvenyessegDatuma = value; }
        }

        private bool _ErvenytelenekIs = false;

        public bool ErvenytelenekIs
        {
            get { return _ErvenytelenekIs; }
            set { _ErvenytelenekIs = value; }
        }

        private bool _CsakErvenytelenek = false;

        public bool CsakErvenytelenek
        {
            get { return _CsakErvenytelenek; }
            set { _CsakErvenytelenek = value; }
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
	[Serializable]
	public class KizaroBeavatkozasOsszerendelesDTO : OsszerendelesDTO
	{
		public string BeavatkozasNev { get; set; }

		public string BeavatkozasKod { get; set; }

		public string KizaroBeavatkozasNev { get; set; }

		public string KizaroBeavatkozasKod { get; set; }

		public string BeavatkozasRovidNev
		{
			get
			{
				return BeavatkozasNev.Length > 40 ? BeavatkozasNev.Substring(0, 37) + "..." : BeavatkozasNev;
			}
		}

		public string KizaroBeavatkozasRovidNev
		{
			get
			{
				return KizaroBeavatkozasNev.Length > 40 ? KizaroBeavatkozasNev.Substring(0, 37) + "..." : KizaroBeavatkozasNev;
			}
		}

		public string BeavatkozasKodEsNev
		{
			get { return BeavatkozasKod + " " + BeavatkozasRovidNev; }
		}

		public string KizaroBeavatkozasKodEsNev
		{
			get { return KizaroBeavatkozasKod + " " + KizaroBeavatkozasRovidNev; }
		}
	}
}
