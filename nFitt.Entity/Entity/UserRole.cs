using System;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class UserRole : ValueEntityBase
    {
        private int _UserId;
        public int UserId
        {
            get
            {
                return _UserId;
            }

            set
            {
                _UserId = value;
            }
        }

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

        public virtual User User { get; set; }
        public virtual Role Role {get;set;}

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
