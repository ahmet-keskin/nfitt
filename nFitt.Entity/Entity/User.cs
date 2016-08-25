using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class User : EntityBase
    {
        #region Properties
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        private string _PhoneNumber;
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

        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
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

        private bool _IsConfirmationRequired;
        public bool IsConfirmationRequired
        {
            get
            {
                return _IsConfirmationRequired;
            }

            set
            {
                _IsConfirmationRequired = value;
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

        public virtual UserType Type { get; set; }

        public virtual List<Role> Roles { get; set; }
        #endregion
        public override ResponseBase<ValueEntityBase> IsValid()
        {
            return new ResponseBase<ValueEntityBase>();
        }
    }
}
