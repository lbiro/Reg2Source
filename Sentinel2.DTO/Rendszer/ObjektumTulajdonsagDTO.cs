using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class ObjektumTulajdonsagDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _ObjektumID = null;

        public long? ObjektumID
        {
            get { return _ObjektumID; }
            set { _ObjektumID = value; }
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
    public class ObjektumTulajdonsagKeresoDTO : ObjektumTulajdonsagDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _ObjektumIDs = null;

        public string ObjektumIDs
        {
            get { return _ObjektumIDs; }
            set { _ObjektumIDs = value; }
        }

        private string _TulajdonsagIDs = null;

        public string TulajdonsagIDs
        {
            get { return _TulajdonsagIDs; }
            set { _TulajdonsagIDs = value; }
        }
    }
}
