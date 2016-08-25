using System;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class UserTypeRole : ValueEntityBase
    {
        private int _RoleId;
        public int RoleId
        {
            get
            {
                return _RoleId;
            }

            set
            {
                _RoleId = value;
            }
        }

        private int _UserTypeId;
        public int UserTypeId
        {
            get
            {
                return _UserTypeId;
            }

            set
            {
                _UserTypeId = value;
            }
        }

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

        public virtual UserType UserType { get; set; }
        public virtual Role Role { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
