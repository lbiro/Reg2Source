using log4net; using System; 
using System.Collections.Generic;
using System.Text;
using AquaSoft.Sentinel2.DTO;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class NyomtatoDTO : BaseDTO
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

        private string _WindowsNev = null;

        public string WindowsNev
        {
            get { return _WindowsNev; }
            set { _WindowsNev = value; }
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
    }
    [Serializable]
    public class NyomtatoKeresoDTO : NyomtatoDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _NevMinta = null;

        public string NevMinta
        {
            get { return _NevMinta; }
            set { _NevMinta = value; }
        }

        private bool _CsakFuggetlenek = false;

        public bool CsakFuggetlenek
        {
            get { return _CsakFuggetlenek; }
            set { _CsakFuggetlenek = value; }
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
