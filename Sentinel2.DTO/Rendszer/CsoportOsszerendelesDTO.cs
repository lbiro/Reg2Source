using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class CsoportOsszerendelesDTO
    {
        private CsoportDTO _CsoportDTO = null;

        public CsoportDTO CsoportDTO
        {
            get { return _CsoportDTO; }
            set { _CsoportDTO = value; }
        }
        private OsszerendelesDTO _OsszerendelesDTO = null;

        public OsszerendelesDTO OsszerendelesDTO
        {
            get { return _OsszerendelesDTO; }
            set { _OsszerendelesDTO = value; }
        }

        public CsoportOsszerendelesDTO(CsoportDTO a, OsszerendelesDTO o)
        {
            this.CsoportDTO = a;
            this.OsszerendelesDTO = o;
        }
    }
}
