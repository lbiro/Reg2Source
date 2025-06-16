using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class TelepulesDTO : BaseDTO
    {
        private long? _ID;
        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _IranyitoSzam;
        public string IranyitoSzam
        {
            get { return _IranyitoSzam; }
            set { _IranyitoSzam = value; }
        }

        private string _TelepulesNev;
        public string TelepulesNev
        {
            get { return _TelepulesNev; }
            set { _TelepulesNev = value; }
        }

        private string _Megye;
        public string Megye
        {
            get { return _Megye; }
            set { _Megye = value; }
        }

        public string IranyitoszamEsNev
        {
            get { return _IranyitoSzam + " " + _TelepulesNev; }
        }

        private string _TelepulesResz;
        public string TelepulesResz
        {
            get { return _TelepulesResz; }
            set { _TelepulesResz = value; }
        }
    }

    public class TelepulesKeresoDTO : TelepulesDTO
    {
        private string _TelepulesNevMinta;
        public string TelepulesNevMinta
        {
            get { return _TelepulesNevMinta; }
            set { _TelepulesNevMinta = value; }
        }

        private string _TelepulesReszNevMinta;
        public string TelepulesReszNevMinta
        {
            get { return _TelepulesReszNevMinta; }
            set { _TelepulesReszNevMinta = value; }
        }

        private string _IranyitoSzamMinta;
        public string IranyitoSzamMinta
        {
            get { return _IranyitoSzamMinta; }
            set { _IranyitoSzamMinta = value; }
        }

        private string _MegyeMinta;
        public string MegyeMinta
        {
            get { return _MegyeMinta; }
            set { _MegyeMinta = value; }
        }

        private string _IDs;
        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }
    }
}
