using System;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class GymPhone : ValueEntityBase
    {
        private int _GymAddressId;
        private string _PhoneNumber;
        private bool _IsDefault;
        private bool _IsActive;

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

        public bool IsDefault
        {
            get
            {
                return _IsDefault;
            }

            set
            {
                _IsDefault = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }

            set
            {
                _PhoneNumber = value;
            }
        }

        public int GymAddressId
        {
            get
            {
                return _GymAddressId;
            }

            set
            {
                _GymAddressId = value;
            }
        }

        public virtual Gym GymAddress { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
