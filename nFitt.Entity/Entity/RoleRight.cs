using System;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class RoleRight : ValueEntityBase
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

        private int _Right;
        public int Right
        {
            get
            {
                return _Right;
            }

            set
            {
                _Right = value;
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
        public virtual Role Role { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
