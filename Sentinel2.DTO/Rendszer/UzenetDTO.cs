using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class UzenetDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Szoveg = null;

        public string Szoveg
        {
            get { return _Szoveg; }
            set { _Szoveg = value; }
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

        private DateTime? _Lejarat = null;

        public DateTime? Lejarat
        {
            get { return _Lejarat; }
            set { _Lejarat = value; }
        }

        private string _FeladoNev = null;

        public string FeladoNev
        {
            get { return _FeladoNev; }
            set { _FeladoNev = value; }
        }
    }

    [Serializable]
    public class UzenetKeresoDTO : UzenetDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
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
