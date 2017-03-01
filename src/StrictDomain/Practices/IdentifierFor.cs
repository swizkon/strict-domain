using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class IdentifierFor<T> where T : class
    {
        readonly object _value;

        public IdentifierFor(object value)
        {
            _value = value;
        }

        public bool Equals(IdentifierFor<T> other)
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

        public static implicit operator Guid(IdentifierFor<T> id)
        {
            if (!(id._value is Guid))
                throw new InvalidCastException("id");

            return (Guid) id._value;
        }

        public static implicit operator IdentifierFor<T>(Guid id)
        {
            return new IdentifierFor<T>(id);
        }


        public static explicit operator long(IdentifierFor<T> id)
        {
            if (!(id._value is long))
                throw new InvalidCastException("id");

            return (long)id._value;
        }
        public static implicit operator IdentifierFor<T>(long id)
        {
            return new IdentifierFor<T>(id);
        }
    }
}
