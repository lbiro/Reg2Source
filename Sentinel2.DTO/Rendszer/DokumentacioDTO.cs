using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class DokumentacioDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _TipusKod = null;

        public string TipusKod
        {
            get { return _TipusKod; }
            set { _TipusKod = value; }
        }

        public string TipusNev
        {
            get
            {
                return DTOSzotar.Nev(Nyelv, "DOKTIPUS", TipusKod);
            }
        }

        private string _AlTipusKod = null;

        public string AlTipusKod
        {
            get { return _AlTipusKod; }
            set { _AlTipusKod = value; }
        }

        public string AlTipusNev
        {
            get
            {
                return DTOSzotar.Nev(Nyelv, "DOKALTIPUS", AlTipusKod);
            }
        }

        private string _Szoveg = null;

        public string Szoveg
        {
            get { return _Szoveg; }
            set { _Szoveg = value; }
        }
		public long? AlairoSzemelyID { get; set; }

		public string AlairoSzemelyNev { get; set; }
    }

    [Serializable]
    public class DokumentacioKeresoDTO : DokumentacioDTO
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

    [Serializable]
    public class ObjektumDokumentacioCsoportDTO : BaseDTO
    {
		/// <summary>
		/// DokumentacioOsszerendeles ID
		/// </summary>
		public long? ID { get; set; }
		
		/// <summary>
		/// DokumentacioOsszerendeles HozzarendeltID
		/// </summary>
		public long? HozzarendeltID { get; set; }
		
		/// <summary>
		/// DokumentacioOsszerendeles ObjektumID
		/// </summary>
        private long? _ObjektumID;
        public long? ObjektumID
        {
            get { return _ObjektumID; }
            set { _ObjektumID = value; }
        }
        public List<DokumentacioCsoportDTO> Csoportok = new List<DokumentacioCsoportDTO>();
    }

    [Serializable]
    public class DokumentacioCsoportDTO
    {
        public CsoportDTO Csoport = null;
        public List<DokumentacioDTO> Dokumentumok=new List<DokumentacioDTO>();
    }

    [Serializable]
    public class ObjektumDokumentacioCsoportKeresoDTO : ObjektumDokumentacioCsoportDTO
    {
        private string _DokumentumAlTipusKodok;
        public string DokumentumAlTipusKodok
        {
            get { return _DokumentumAlTipusKodok; }
            set { _DokumentumAlTipusKodok = value; }
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

		private long? _DokID;
		public long? DokID
		{
			get { return _DokID; }
			set { _DokID = value; }
		}

		private string _SzerepkorIDs;
		public string SzerepkorIDs
		{
			get { return _SzerepkorIDs; }
			set { _SzerepkorIDs = value; }
		}

		public string ObjektumIDs { get; set; }
    }

}
