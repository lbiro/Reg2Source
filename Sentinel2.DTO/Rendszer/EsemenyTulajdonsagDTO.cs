using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class EsemenyTulajdonsagDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _EsemenyID = null;

        public long? EsemenyID
        {
            get { return _EsemenyID; }
            set { _EsemenyID = value; }
        }

        private long? _TulajdonsagID = null;

        public long? TulajdonsagID
        {
            get { return _TulajdonsagID; }
            set { _TulajdonsagID = value; }
        }

        private string _Ertek = null;

        public string Ertek
        {
            get { return _Ertek; }
            set { _Ertek = value; }
        }
    }

    [Serializable]
    public class EsemenyTulajdonsagKeresoDTO : EsemenyTulajdonsagDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _EsemenyIDs = null;

        public string EsemenyIDs
        {
            get { return _EsemenyIDs; }
            set { _EsemenyIDs = value; }
        }

        private string _TulajdonsagIDs = null;

        public string TulajdonsagIDs
        {
            get { return _TulajdonsagIDs; }
            set { _TulajdonsagIDs = value; }
        }
    }
}
