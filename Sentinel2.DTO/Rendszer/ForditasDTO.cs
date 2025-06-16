using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class ForditasDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _DTONev = null;

        public string DTONev
        {
            get { return _DTONev; }
            set { _DTONev = value; }
        }

        private long? _DTOID = null;

        public long? DTOID
        {
            get { return _DTOID; }
            set { _DTOID = value; }
        }

        private string _TulajdonsagNev = null;

        public string TulajdonsagNev
        {
            get { return _TulajdonsagNev; }
            set { _TulajdonsagNev = value; }
        }

        private string _NyelvKod = null;

        public string NyelvKod
        {
            get { return _NyelvKod; }
            set { _NyelvKod = value; }
        }

        private string _Forditas = null;

        public string Forditas
        {
            get { return _Forditas; }
            set { _Forditas = value; }
        }

        public string NyelvNev
        {
            get { return DTOSzotar.Nev(Nyelv, "NYELV", NyelvKod); }
        }

    }

    [Serializable]
    public class ForditasKeresoDTO : ForditasDTO
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
