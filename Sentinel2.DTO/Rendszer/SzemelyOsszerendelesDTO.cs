using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class SzemelyOsszerendelesDTO
    {
        private SzemelyDTO _SzemelyDTO = null;

        public SzemelyDTO SzemelyDTO
        {
            get { return _SzemelyDTO; }
            set { _SzemelyDTO = value; }
        }
        private OsszerendelesDTO _OsszerendelesDTO = null;

        public OsszerendelesDTO OsszerendelesDTO
        {
            get { return _OsszerendelesDTO; }
            set { _OsszerendelesDTO = value; }
        }

        public SzemelyOsszerendelesDTO(SzemelyDTO a, OsszerendelesDTO o)
        {
            this.SzemelyDTO = a;
            this.OsszerendelesDTO = o;
        }
    }
}
