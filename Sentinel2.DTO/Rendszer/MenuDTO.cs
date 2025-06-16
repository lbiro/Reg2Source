using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class MenuDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _SzuloID = null;

        public long? SzuloID
        {
            get { return _SzuloID; }
            set { _SzuloID = value; }
        }

        private int? _Pozicio = null;

        public int? Pozicio
        {
            get { return _Pozicio; }
            set { _Pozicio = value; }
        }

        private string _Szoveg = null;

        public string Szoveg
        {
            get { return _Szoveg; }
            set { _Szoveg = value; }
        }

        private string _Link = null;

        public string Link
        {
            get { return _Link; }
            set { _Link = value; }
        }

        private string _Ikon = null;

        public string Ikon
        {
            get { return _Ikon; }
            set { _Ikon = value; }
        }


        private string _Target = null;

        public string Target
        {
            get { return _Target; }
            set { _Target = value; }
        }
    }

    [Serializable]
    public class MenuKeresoDTO : MenuDTO
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
