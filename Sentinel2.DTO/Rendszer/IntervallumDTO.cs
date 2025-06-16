using System;
using System.Collections.Generic;
using System.Text;

namespace AquaSoft.Sentinel2.DTO
{
    [Serializable]
    public class IntervallumDTO : IComparable<IntervallumDTO>
    {
        private DateTime _IntervallumKezdete;

        public DateTime IntervallumKezdete
        {
            get { return _IntervallumKezdete; }
            set { _IntervallumKezdete = value; }
        }

        private DateTime _IntervallumVege;

        public DateTime IntervallumVege
        {
            get { return _IntervallumVege; }
            set { _IntervallumVege = value; }
        }

        public IntervallumDTO(DateTime IntervallumKezdete, DateTime IntervallumVege)
        {
            this.IntervallumKezdete = IntervallumKezdete;
            this.IntervallumVege = IntervallumVege;
        }

        public int CompareTo(IntervallumDTO other)
        {
            return this.IntervallumKezdete.CompareTo(other.IntervallumKezdete);
        }
    }
}
