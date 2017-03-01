using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public struct UnambiguousIdentifier<T>
        where T: class
    {
        readonly Guid _value;

        public UnambiguousIdentifier(Guid value)
        {
            _value = value;
        }

        public bool Equals(UnambiguousIdentifier<T> other)
        {
            return _value.Equals(other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is T && Equals((T)obj);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public static implicit operator Guid(UnambiguousIdentifier<T> id)
        {
            return id._value;
        }

        public static implicit operator UnambiguousIdentifier<T> (Guid id)
        {
            return new UnambiguousIdentifier<T>(id);
        }
    }
}
