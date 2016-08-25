using System;

namespace Framework.Data.Entity
{
    public interface IEntity<T>
    {
        T RecordId { get; set; }
    }
}
