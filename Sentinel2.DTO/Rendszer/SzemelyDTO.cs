using log4net; using System; 
using System.Collections.Generic;
using System.Text;


namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class SzemelyDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Nev = null;

        public string Nev
        {
            get { return _Nev; }
            set { _Nev = value; }
        }

        private string _EloNev = null;

        public string EloNev
        {
            get { return _EloNev; }
            set { _EloNev = value; }
        }

        private string _VezetekNev = null;

        public string VezetekNev
        {
            get { return _VezetekNev; }
            set { _VezetekNev = value; }
        }

        private string _KeresztNev = null;

        public string KeresztNev
        {
            get { return _KeresztNev; }
            set { _KeresztNev = value; }
        }

        private string _UtoNev = null;

        public string UtoNev
        {
            get { return _UtoNev; }
            set { _UtoNev = value; }
        }

        private string _SzuletesiNev = null;

        public string SzuletesiNev
        {
            get { return _SzuletesiNev; }
            set { _SzuletesiNev = value; }
        }

        private string _AnyjaNeve = null;

        public string AnyjaNeve
        {
            get { return _AnyjaNeve; }
            set { _AnyjaNeve = value; }
        }

        private DateTime? _SzuletesiDatum = null;

        public DateTime? SzuletesiDatum
        {
            get { return _SzuletesiDatum; }
            set { _SzuletesiDatum = value; }
        }

        private string _EmailCim = null;

        public string EmailCim
        {
            get { return _EmailCim; }
            set { _EmailCim = value; }
        }

        private long? _LakcimID = null;

        public long? LakcimID
        {
            get { return _LakcimID; }
            set { _LakcimID = value; }
        }

        private long? _LevelezesiCimID = null;

        public long? LevelezesiCimID
        {
            get { return _LevelezesiCimID; }
            set { _LevelezesiCimID = value; }
        }

        private string _Telefon = null;

        public string Telefon
        {
            get { return _Telefon; }
            set { _Telefon = value; }
        }

        private string _Mobil = null;

        public string Mobil
        {
            get { return _Mobil; }
            set { _Mobil = value; }
        }

        private string _Nem = null;

        public string Nem
        {
            get { return _Nem; }
            set { _Nem = value; }
        }

        private string _MagyarTAJ = null;

        public string MagyarTAJ
        {
            get { return _MagyarTAJ; }
            set { _MagyarTAJ = value; }
        }

        private string _KulfoldiTAJ = null;

        public string KulfoldiTAJ
        {
            get { return _KulfoldiTAJ; }
            set { _KulfoldiTAJ = value; }
        }

        public string TAJ
        {
            get { return _MagyarTAJ != null ? MagyarTAJ : KulfoldiTAJ; }
        }

        private string _AllampolgarsagKod = null;

        public string AllampolgarsagKod
        {
            get { return _AllampolgarsagKod; }
            set { _AllampolgarsagKod = value; }
        }

        private List<AzonositoDTO> _Azonositok = new List<AzonositoDTO>();

        public List<AzonositoDTO> Azonositok
        {
            get { return _Azonositok; }
            set { _Azonositok = value; }
        }

        private List<CsoportDTO> _Csoportok = new List<CsoportDTO>();

        public List<CsoportDTO> Csoportok
        {
            get { return _Csoportok; }
            set { _Csoportok = value; }
        }
        
        public string Pecsetszam
        {
            get
            {
                string Pecsetszam = null;
                foreach (AzonositoDTO azonosito in Azonositok)
                {
                    if (azonosito.TipusKod == "PECSETSZAM")
                    {
                        Pecsetszam = azonosito.Kulcs;
                        break;
                    }
                }
                return Pecsetszam;
            }
        }

        public string NevEsPecsetszam
        {
            get
            {
                return Nev + " " + Pecsetszam;
            }
        }

        private string _Torzsszam;
        public string Torzsszam
        {
            get { return _Torzsszam; }
            set { _Torzsszam = value; }
        }

        private string _SzobaSzam;
        public string SzobaSzam
        {
            get { return _SzobaSzam; }
            set { _SzobaSzam = value; }
        }

        private string _AzonositoKulcs;
        public string AzonositoKulcs
        {
            get { return _AzonositoKulcs; }
            set { _AzonositoKulcs = value; }
        }

        private string _KulsoID;
        public string KulsoID
        {
            get { return _KulsoID; }
            set { _KulsoID = value; }
        }

        private string _SegitoJobbSzam;
        public string SegitoJobbSzam
        {
            get { return _SegitoJobbSzam; }
            set { _SegitoJobbSzam = value; }
        }

        private string _MenekultSzam;
        public string MenekultSzam
        {
            get { return _MenekultSzam; }
            set { _MenekultSzam = value; }
        }

        private string _Kotetszam;
        public string Kotetszam
        {
            get { return _Kotetszam; }
            set { _Kotetszam = value; }
        }

        private bool? _Beteg;
        public bool? Beteg
        {
            get { return _Beteg; }
            set { _Beteg = value; }
        }

        private bool? _BekuldoOrvos;
        public bool? BekuldoOrvos
        {
            get { return _BekuldoOrvos; }
            set { _BekuldoOrvos = value; }
        }

        private bool? _KezeloOrvos;
        public bool? KezeloOrvos
        {
            get { return _KezeloOrvos; }
            set { _KezeloOrvos = value; }
        }

		private string _Titulus;
		public string Titulus
		{
			get { return _Titulus; }
			set { _Titulus = value; }
		}
		private long? _KezeloSzakrendelesID = null;

		public long? KezeloSzakrendelesID
		{
			get { return _KezeloSzakrendelesID; }
			set { _KezeloSzakrendelesID = value; }
		}
		private DateTime? _KGYErvenyessegiDatum = null;

		public DateTime? KGYErvenyessegiDatum
		{
			get { return _KGYErvenyessegiDatum; }
			set { _KGYErvenyessegiDatum = value; }
		}

		public string KozgyogySzam { get; set; }

		/// <summary>
		/// Létrehozáshoz (alap esetben true)
		/// </summary>
        private bool? _Aktiv = true;

        public bool? Aktiv
        {
            get { return _Aktiv; }
            set { _Aktiv = value; }
        }

		public string Azonosito { get; set; }
    }

    [Serializable]
    public class SzemelyKeresoDTO : SzemelyDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _TAJKereso = null;

        public string TAJKereso
        {
            get { return _TAJKereso; }
            set { _TAJKereso = value; }
        }

        private string _LakcimIDs = null;

        public string LakcimIDs
        {
            get { return _LakcimIDs; }
            set { _LakcimIDs = value; }
        }

        private string _LevelezesiCimIDs = null;

        public string LevelezesiCimIDs
        {
            get { return _LevelezesiCimIDs; }
            set { _LevelezesiCimIDs = value; }
        }

        private string _NevMinta = null;

        public string NevMinta
        {
            get { return _NevMinta; }
            set { _NevMinta = value; }
        }

        private string _VezetekNevMinta = null;

        public string VezetekNevMinta
        {
            get { return _VezetekNevMinta; }
            set { _VezetekNevMinta = value; }
        }

        private string _AnyjaNeveMinta = null;

        public string AnyjaNeveMinta
        {
            get { return _AnyjaNeveMinta; }
            set { _AnyjaNeveMinta = value; }
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

        private long? _CsoportID = null;

        public long? CsoportID
        {
            get { return _CsoportID; }
            set { _CsoportID = value; }
        }

        private String _CsoportIDs = null;

        public String CsoportIDs
        {
            get { return _CsoportIDs; }
            set { _CsoportIDs = value; }
        }

        private DateTime? _CsoportErvenyesseg = null;

        public DateTime? CsoportErvenyesseg
        {
            get { return _CsoportErvenyesseg; }
            set { _CsoportErvenyesseg = value; }
        }

        private DateTime? _AzonositoErvenyesseg = null;

        public DateTime? AzonositoErvenyesseg
        {
            get { return _AzonositoErvenyesseg; }
            set { _AzonositoErvenyesseg = value; }
        }

        private String _CsoportKod = null;

        public String CsoportKod
        {
            get { return _CsoportKod; }
            set { _CsoportKod = value; }
        }

        private String _CsoportKodok = null;

        public String CsoportKodok
        {
            get { return _CsoportKodok; }
            set { _CsoportKodok = value; }
        }

        
        private String _CsoportTipusKod = null;

        public String CsoportTipusKod
        {
            get { return _CsoportTipusKod; }
            set { _CsoportTipusKod = value; }
        }

        private string _KuraFinanszIDs;
        public string KuraFinanszIDs
        {
            get { return _KuraFinanszIDs; }
            set { _KuraFinanszIDs = value; }
        }

        private string _AzonositoTipusKod = null;

        public string AzonositoTipusKod
        {
            get { return _AzonositoTipusKod; }
            set { _AzonositoTipusKod = value; }
        }

        private bool _SzerepkorokIs;

        public bool SzerepkorokIs
        {
            get { return _SzerepkorokIs; }
            set { _SzerepkorokIs = value; }
        }
		/// <summary>
		/// Lekérdezéshez (true/false)
		/// </summary>
		public bool? Aktivokat { get; set; }

		public string EmailCimek { get; set; }

		public bool CsoportNelkuliekIs { get; set; }

		public string TelephelyIDs { get; set; }
    }

    [Serializable]
    public class SzemelyCsoportDTO : SzemelyDTO
    {
        private bool _Kiemelt = false;

        public bool Kiemelt
        {
            get { return _Kiemelt; }
            set { _Kiemelt = value; }
        }

        private long? _CsoportID;

        public long? CsoportID
        {
            get { return _CsoportID; }
            set { _CsoportID = value; }
        }

        private string _CsoportNev;

        public string CsoportNev
        {
            get { return _CsoportNev; }
            set { _CsoportNev = value; }
        }

        public string KiemeltNev
        {
            get
            {
                return Kiemelt ? "<span style=\"color:#FF0000;\">" + Nev + "</span>" : Nev;
            }
        }

        public bool IDEgyezik(SzemelyCsoportDTO o)
        {
            return this.ID == o.ID;
        }

        private string _CsoportKod;

        public string CsoportKod
        {
            get { return _CsoportKod; }
            set { _CsoportKod = value; }
        }
	
    }
}
