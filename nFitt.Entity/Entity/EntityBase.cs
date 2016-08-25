using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Data.Entity;

namespace nFitt.Data.Entity
{
    public abstract class ValueEntityBase : IValueEntity<int>
    {
        #region IEntity Implementation
        private int _CreatedBy;
        public int CreatedBy
        {
            get
            {
                return _CreatedBy;
            }

            set
            {
                _CreatedBy = value;
            }
        }

        private DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }

            set
            {
                _CreatedDate = value;
            }
        }

        private int _ModifiedBy;
        public int ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }

            set
            {
                _ModifiedBy = value;
            }
        }

        private DateTime _ModifiedDate;
        public DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }

            set
            {
                _ModifiedDate = value;
            }
        }
        #endregion

        public abstract Framework.Data.Messaging.ResponseBase<ValueEntityBase> IsValid();
    }

    public abstract class EntityBase:ValueEntityBase, IEntity<int>
    {
        private int? _RecordId;
        public int RecordId
        {
            get
            {
                return _RecordId ?? 0;
            }

            set
            {
                _RecordId = value;
            }
        }
    }
}
