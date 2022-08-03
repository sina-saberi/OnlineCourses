using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Domain.Core.Base
{
    public abstract class Entity<Tkey>
    {
        public Tkey Id { get; protected set; }

        public override bool Equals(object? obj)
        {
            var entity = obj as Entity<Tkey>;
            return entity != null &&
                GetType() == entity.GetType() &&
                EqualityComparer<Tkey>.Default.Equals(Id, entity.Id);
        }

        public static bool operator ==(Entity<Tkey> a, Entity<Tkey> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity<Tkey> a, Entity<Tkey> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetHashCode(), Id);
        }

    }
}
