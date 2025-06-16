using System;
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
	[Serializable]
	public class SorozatDTO : BaseDTO
	{
		private string _Kod;
		public string Kod
		{
			get { return _Kod; }
			set { _Kod = value; }
		}

		private long? _Ertek;
		public long? Ertek
		{
			get { return _Ertek; }
			set { _Ertek = value; }
		}
	}

	[Serializable]
	public class SorozatKeresoDTO : SorozatDTO
	{
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
	}
}
