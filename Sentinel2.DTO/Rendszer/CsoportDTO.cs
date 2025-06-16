using log4net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace AquaSoft.Sentinel2.DTO
{
	[Serializable]
	public class CsoportDTO : BaseDTO
	{
		private long? _ID = null;

		public long? ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		private string _Nev = null;

		public string Nev
		{
			get { return _Nev; }
			set { _Nev = value; }
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
				return DTOSzotar.Nev(Nyelv, "CSOPORT", TipusKod);
			}
		}

		private string _Kod = null;

		public string Kod
		{
			get { return _Kod; }
			set { _Kod = value; }
		}

		public string KodEsNev
		{
			get { return _Kod + " " + _Nev; }
		}

		private int? _CsoportbaTartozokSzama;

		public int? CsoportbaTartozokSzama
		{
			get { return _CsoportbaTartozokSzama; }
			set { _CsoportbaTartozokSzama = value; }
		}

		private int? _Darabszam;

		public int? Darabszam
		{
			get { return _Darabszam; }
			set { _Darabszam = value; }
		}

		/// <summary>
		/// ElojegyzesBeavatkozasLekerdezes esetén!!! 
		/// </summary>
		public long? BeavatkozasCsoportOsszerendelesID { get; set; }

	}

	[Serializable]
	public class CsoportKeresoDTO : CsoportDTO
	{
		private string _IDs = null;

		public string IDs
		{
			get { return _IDs; }
			set { _IDs = value; }
		}

		private string _Kodok = null;

		public string Kodok
		{
			get { return _Kodok; }
			set { _Kodok = value; }
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

		private bool _CsoportbaTartozokSzamatIs = false;

		public bool CsoportbaTartozokSzamatIs
		{
			get { return _CsoportbaTartozokSzamatIs; }
			set { _CsoportbaTartozokSzamatIs = value; }
		}

	}
}
