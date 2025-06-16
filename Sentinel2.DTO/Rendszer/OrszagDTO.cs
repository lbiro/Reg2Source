using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class OrszagDTO : BaseDTO
    {
        private string _Kod = null;

        public string Kod
        {
            get { return _Kod; }
            set { _Kod = value; }
        }

        private string _Nev = null;

        public string Nev
        {
            get { return _Nev; }
            set { _Nev = value; }
        }

        private string _Kod2 = null;

        public string Kod2
        {
            get { return _Kod2; }
            set { _Kod2 = value; }
        }

        private string _Kod3 = null;

        public string Kod3
        {
            get { return _Kod3; }
            set { _Kod3 = value; }
        }

        public string Kod3EsNev
        {
            get { return Kod3 + " " + Nev; }
        }
    }

    [Serializable]
    public class OrszagKeresoDTO : OrszagDTO
    {
        private string _NevMinta = null;

        public string NevMinta
        {
            get { return _NevMinta; }
            set { _NevMinta = value; }
        }
    }
}
