using System;
using System.Collections.Generic;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class Role: EntityBase
    {
        private string _RoleName;
        public string RoleName
        {
            get
            {
                return _RoleName;
            }

            set
            {
                _RoleName = value;
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

        public virtual List<User> Users { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
