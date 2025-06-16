using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class NaptarDTO : BaseDTO
    {
        private DateTime? _Datum = null;

        public DateTime? Datum
        {
            get { return _Datum; }
            set { _Datum = value; }
        }

        private List<string> _TipusKodok = null;

        public List<string> TipusKodok
        {
            get { return _TipusKodok; }
            set { _TipusKodok = value; }
        }

        public List<string> TipusNevek
        {
            get
            {
                List<string> result = new List<string>();
                foreach (string kod in TipusKodok)
                {
                    result.Add(DTOSzotar.Nev(Nyelv, "NAPTIPUS", kod));
                }
                return result;
            }
        }
    }

    [Serializable]
    public class NaptarKeresoDTO : NaptarDTO
    {
        private DateTime? _KezdoDatum = null;

        public DateTime? KezdoDatum
        {
            get { return _KezdoDatum; }
            set { _KezdoDatum = value; }
        }

        private DateTime? _BefejezoDatum = null;

        public DateTime? BefejezoDatum
        {
            get { return _BefejezoDatum; }
            set { _BefejezoDatum = value; }
        }
    }
}
