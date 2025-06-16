using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class AzonositoOsszerendelesDTO
    {
        private AzonositoDTO _AzonositoDTO = null;

        public AzonositoDTO AzonositoDTO
        {
            get { return _AzonositoDTO; }
            set { _AzonositoDTO = value; }
        }
        private OsszerendelesDTO _OsszerendelesDTO = null;

        public OsszerendelesDTO OsszerendelesDTO
        {
            get { return _OsszerendelesDTO; }
            set { _OsszerendelesDTO = value; }
        }

        public AzonositoOsszerendelesDTO(AzonositoDTO a, OsszerendelesDTO o)
        {
            this.AzonositoDTO = a;
            this.OsszerendelesDTO = o;
        }

        public AzonositoOsszerendelesDTO()
        {
        }
    }
}
