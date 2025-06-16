using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    public class MunkahelyNyomtatoDTO
    {
        private NyomtatoDTO _NyomtatoDTO;

        public NyomtatoDTO NyomtatoDTO
        {
            get { return _NyomtatoDTO; }
            set { _NyomtatoDTO = value; }
        }

        private MunkahelyDTO _MunkahelyDTO;

        public MunkahelyDTO MunkahelyDTO
        {
            get { return _MunkahelyDTO; }
            set { _MunkahelyDTO = value; }
        }

        public MunkahelyNyomtatoDTO(MunkahelyDTO m, NyomtatoDTO ny)
        {
            NyomtatoDTO = ny;
            MunkahelyDTO = m;
        }

    }
}
