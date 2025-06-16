using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class DokumentacioTipusDTO : BaseDTO
    {
        private long? _ID = null;

        public long? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _TipusKod = null;

        public string TipusKod
        {
            get { return _TipusKod; }
            set { _TipusKod = value; }
        }

        public string TipusNev
        {
            get
            {
                return DTOSzotar.Nev(Nyelv, "DOKTIPUS", TipusKod);
            }
        }

        private string _SablonTipusKod = null;

        public string SablonTipusKod
        {
            get { return _SablonTipusKod; }
            set { _SablonTipusKod = value; }
        }

        public string SablonTipusNev
        {
            get
            {
                return DTOSzotar.Nev(Nyelv, "SABLONTIPUS", SablonTipusKod);
            }
        }

        private int? _Sorrend = null;

        public int? Sorrend
        {
            get { return _Sorrend; }
            set { _Sorrend = value; }
        }


        private long? _FurdoID;

        public long? FurdoID
        {
            get { return _FurdoID; }
            set { _FurdoID = value; }
        }
	
    }

    [Serializable]
    public class DokumentacioTipusKeresoDTO : DokumentacioTipusDTO
    {
        private string _IDs = null;

        public string IDs
        {
            get { return _IDs; }
            set { _IDs = value; }
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

        private bool _TipusKodCsoport = false;

        public bool TipusKodCsoport
        {
            get { return _TipusKodCsoport; }
            set { _TipusKodCsoport = value; }
        }
	

    }
}
