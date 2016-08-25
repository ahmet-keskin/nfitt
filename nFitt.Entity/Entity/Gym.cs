using System;
using System.Collections.Generic;
using Framework.Data.Messaging;

namespace nFitt.Data.Entity
{
    public class Gym: EntityBase
    {
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

        private int _PrimaryContactId;
        public int PrimaryContactId
        {
            get
            {
                return _PrimaryContactId;
            }

            set
            {
                _PrimaryContactId = value;
            }
        }

        private string _LogoPhotoPath;
        public string LogoPhotoPath
        {
            get
            {
                return _LogoPhotoPath;
            }

            set
            {
                _LogoPhotoPath = value;
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

        public virtual User PrimaryContact { get; set; }

        public virtual List<GymAddress> Addresses { get; set; }

        public override ResponseBase<ValueEntityBase> IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
