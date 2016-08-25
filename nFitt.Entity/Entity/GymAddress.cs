using System;
using System.Collections.Generic;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class GymAddress : ValueEntityBase
    {
        private int _GymId;
        private string _Street;
        private string _PostalCode;
        private bool _IsHeadQuarter;
        private decimal _Longitude;
        private decimal _Latitude;
        private bool _IsActive;

        public int GymId
        {
            get
            {
                return _GymId;
            }

            set
            {
                _GymId = value;
            }
        }

        public string Street
        {
            get
            {
                return _Street;
            }

            set
            {
                _Street = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return _PostalCode;
            }

            set
            {
                _PostalCode = value;
            }
        }

        public bool IsHeadQuarter
        {
            get
            {
                return _IsHeadQuarter;
            }

            set
            {
                _IsHeadQuarter = value;
            }
        }

        public decimal Longitude
        {
            get
            {
                return _Longitude;
            }

            set
            {
                _Longitude = value;
            }
        }

        public decimal Latitude
        {
            get
            {
                return _Latitude;
            }

            set
            {
                _Latitude = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public virtual Gym Gym { get; set; }

        public virtual List<GymPhone> Phones { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
