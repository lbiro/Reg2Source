using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class SzotarDTO : BaseDTO
    {
        private string _Kod = null;

        public string Kod
        {
            get { return _Kod; }
            set { _Kod = value; }
        }

        private string _NyelvKod = null;

        public string NyelvKod
        {
            get { return _NyelvKod; }
            set { _NyelvKod = value; }
        }

        private string _NyelvNev = null;

        public string NyelvNev
        {
            get { return _NyelvNev; }
            set { _NyelvNev = value; }
        }

        private string _Nev = null;

        public string Nev
        {
            get { return _Nev; }
            set { _Nev = value; }
        }

        public string KodEsNev
        {
            get { return "(" + _Kod + ") " + _Nev; }
        }

        public string NevEsKod
        {
            get { return _Nev + "(" + _Kod + ") "; }
        }

        private string _Ertek = null;

        public string Ertek
        {
            get { return _Ertek; }
            set { _Ertek = value; }
        }

        public string ErtekEsNev
        {
            get { return _Ertek + " " + _Nev; }
        }

        private string _TipusKod = null;

        public string TipusKod
        {
            get { return _TipusKod; }
            set { _TipusKod = value; }
        }

        private string _TipusNev = null;

        public string TipusNev
        {
            get { return _TipusNev; }
            set { _TipusNev = value; }
        }

		public SzotarDTO() { }

		public SzotarDTO(string kod, string nev)
		{
			Kod = kod;
			Nev = nev;
		}
    }

    [Serializable]
    public class SzotarKeresoDTO : SzotarDTO
    {
        private string _Kodok = null;

        public string Kodok
        {
            get { return _Kodok; }
            set { _Kodok = value; }
        }

        private string _TipusKodok = null;

        public string TipusKodok
        {
            get { return _TipusKodok; }
            set { _TipusKodok = value; }
        }

        private string _NevMinta = null;

        public string NevMinta
        {
            get { return _NevMinta; }
            set { _NevMinta = value; }
        }

        private string _TipusNevMinta = null;

        public string TipusNevMinta
        {
            get { return _TipusNevMinta; }
            set { _TipusNevMinta = value; }
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

        private string _KodMinta = null;

        public string KodMinta
        {
            get { return _KodMinta; }
            set { _KodMinta = value; }
        }
    }
}
