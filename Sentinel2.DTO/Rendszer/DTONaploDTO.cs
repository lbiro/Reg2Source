using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class DTONaploDTO :  BaseDTO
    {
        private long? _ID;
        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _DTOID;
        public long? DTOID
        {
            get { return _DTOID; }
            set { _DTOID = value; }
        }

        private string _Nev;
        public string Nev
        {
            get { return _Nev; }
            set { _Nev = value; }
        }

        private string _TulajdonsagNev;
        public string TulajdonsagNev
        {
            get { return _TulajdonsagNev; }
            set { _TulajdonsagNev = value; }
        }

        private string _TulajdonsagErtek;
        public string TulajdonsagErtek
        {
            get { return _TulajdonsagErtek; }
            set { _TulajdonsagErtek = value; }
        }

        private string _RogzNev;
        public string RogzNev
        {
            get { return _RogzNev; }
            set { _RogzNev = value; }
        }
    }

    [Serializable]
    public class DTONaploKeresoDTO : DTONaploDTO
    {
        private string _IDs = null;
        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
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
    }
}
