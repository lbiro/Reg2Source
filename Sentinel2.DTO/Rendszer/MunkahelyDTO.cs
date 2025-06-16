using log4net; using System; 
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class MunkahelyDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long? _TipusID;

        public long? TipusID
        {
            get { return _TipusID; }
            set { _TipusID = value; }
        }


        private string _TipusNev = null;

        public string TipusNev
        {
            get { return _TipusNev; }
            set { _TipusNev = value; }
        }

        private string _Nev = null;

        private string _TipusKod;

        public string TipusKod
        {
            get { return _TipusKod; }
            set { _TipusKod = value; }
        }

        public string Nev
        {
            get { return _Nev; }
            set { _Nev = value; }
        }

        public string TipusEsNev
        {
            get { return _TipusNev + " " + _Nev; }
        }

        private string _IP = null;

        public string IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        private string _HostNev = null;

        public string HostNev
        {
            get { return _HostNev; }
            set { _HostNev = value; }
        }

        public bool IDEgyezik(MunkahelyDTO o)
        {
            return this.ID == o.ID;
        }

        private string _ProxyURL;
        public string ProxyURL
        {
            get { return _ProxyURL; }
            set { _ProxyURL = value; }
        }

        private string _ProxyLogin;
        public string ProxyLogin
        {
            get { return _ProxyLogin; }
            set { _ProxyLogin = value; }
        }

        private string _ProxyJelszo;
        public string ProxyJelszo
        {
            get { return _ProxyJelszo; }
            set { _ProxyJelszo = value; }
        }

        private int? _Port;
        public int? Port
        {
            get { return _Port; }
            set { _Port = value; }
        }

        private bool? _VanProxyOlvaso;

        public bool? VanProxyOlvaso
        {
            get { return _VanProxyOlvaso; }
            set { _VanProxyOlvaso = value; }
        }

        private string _ProxyOlvasoPortParams;

        public string ProxyOlvasoPortParams
        {
            get { return _ProxyOlvasoPortParams; }
            set { _ProxyOlvasoPortParams = value; }
        }

        private string _ProxyOlvasoTipus;

        public string ProxyOlvasoTipus
        {
            get { return _ProxyOlvasoTipus; }
            set { _ProxyOlvasoTipus = value; }
        }

        private string _ProxyOlvasoStartByte;

        public string ProxyOlvasoStartByte
        {
            get { return _ProxyOlvasoStartByte; }
            set { _ProxyOlvasoStartByte = value; }
        }

        private long? _TelephelyID;

        public long? TelephelyID
        {
            get { return _TelephelyID; }
            set { _TelephelyID = value; }
        }
    }

    [Serializable]
    public class MunkahelyKeresoDTO : MunkahelyDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
        }

        private string _TelephelyIDs;

        public string TelephelyIDs
        {
            get { return _TelephelyIDs; }
            set { _TelephelyIDs = value; }
        }

        private long? _FurdoID;

        public long? FurdoID
        {
            get { return _FurdoID; }
            set { _FurdoID = value; }
        }

        private string _IPMinta = null;

        public string IPMinta
        {
            get { return _IPMinta; }
            set { _IPMinta = value; }
        }

        private string _NevMinta = null;

        public string NevMinta
        {
            get { return _NevMinta; }
            set { _NevMinta = value; }
        }

        private bool _ToroltekIs = false;

        public bool ToroltekIs
        {
            get { return _ToroltekIs; }
            set { _ToroltekIs = value; }
        }

        private bool _CsakToroltek = false;

        public bool CsakToroltek
        {
            get { return _CsakToroltek; }
            set { _CsakToroltek = value; }
        }

        private DateTime? _RogzDatumKezdete = null;

        public DateTime? RogzDatumKezdete
        {
            get { return _RogzDatumKezdete; }
            set { _RogzDatumKezdete = value; }
        }
        private DateTime? _RogzDatumVege = null;

        public DateTime? RogzDatumVege
        {
            get { return _RogzDatumVege; }
            set { _RogzDatumVege = value; }
        }
        private DateTime? _ModDatumKezdete = null;

        public DateTime? ModDatumKezdete
        {
            get { return _ModDatumKezdete; }
            set { _ModDatumKezdete = value; }
        }
        private DateTime? _ModDatumVege = null;

        public DateTime? ModDatumVege
        {
            get { return _ModDatumVege; }
            set { _ModDatumVege = value; }
        }
        private DateTime? _TorlDatumKezdete = null;

        public DateTime? TorlDatumKezdete
        {
            get { return _TorlDatumKezdete; }
            set { _TorlDatumKezdete = value; }
        }
        private DateTime? _TorlDatumVege = null;

        public DateTime? TorlDatumVege
        {
            get { return _TorlDatumVege; }
            set { _TorlDatumVege = value; }
        }
    }
}
