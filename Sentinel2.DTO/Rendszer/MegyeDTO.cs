using System;
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
     public class MegyeDTO 
    {
        private long? _ID;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Kod;

        public string Kod
        {
            get { return _Kod; }
            set { _Kod = value; }
        }

        private string _Nev;

        public string Nev
        {
            get { return _Nev; }
            set { _Nev = value; }
        }

        public string Nev2
        {
            get { return _Nev.Split(' ')[0]; }
        }

        private string _SpecKod;

        public string SpecKod
        {
            get { return _SpecKod; }
            set { _SpecKod = value; }
        }
	

        private String _Nyelv = null;

        public String Nyelv
        {
            get { return _Nyelv; }
            set { _Nyelv = value; }
        }

        private string _MunkamenetAzonosito;

        public string MunkamenetAzonosito
        {
            get { return _MunkamenetAzonosito; }
            set { _MunkamenetAzonosito = value; }
        }
	
    }

    [Serializable]
    public class MegyeKeresoDTO : MegyeDTO
    {
        private string _IDs;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }
	
    }
}
