using System;
using System.Collections.Generic;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class UserType: EntityBase
    {
        private string _TypeName;
        public string TypeName
        {
            get
            {
                return _TypeName;
            }

            set
            {
                _TypeName = value;
            }
        }

        public virtual List<User> Users { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
