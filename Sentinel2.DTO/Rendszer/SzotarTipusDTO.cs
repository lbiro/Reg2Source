using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class SzotarTipusDTO : BaseDTO
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

        private string _Kategoria = null;
        
        public string Kategoria
        {
            get { return _Kategoria; }
            set { _Kategoria = value; }
        }
    }

    [Serializable]
    public class SzotarTipusKeresoDTO : SzotarTipusDTO
    {
        private string _Kodok = null;

        public string Kodok
        {
            get { return _Kodok; }
            set { _Kodok = value; }
        }

        private string _NevMinta = null;

        public string NevMinta
        {
            get { return _NevMinta; }
            set { _NevMinta = value; }
        }

        private string _KodMinta;

        public string KodMinta
        {
            get { return _KodMinta; }
            set { _KodMinta = value; }
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

        private string _TiltottKodok = null;

        public string TiltottKodok
        {
            get { return _TiltottKodok; }
            set { _TiltottKodok = value; }
        }

        private string _TiltottKategoria = null;

        public string TiltottKategoria
        {
            get { return _TiltottKategoria; }
            set { _TiltottKategoria = value; }
        }

        private string _TiltottKategoriak = null;

        public string TiltottKategoriak
        {
            get { return _TiltottKategoriak; }
            set { _TiltottKategoriak = value; }
        }

        private string _Kategoriak = null;

        public string Kategoriak
        {
            get { return _Kategoriak; }
            set { _Kategoriak = value; }
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
