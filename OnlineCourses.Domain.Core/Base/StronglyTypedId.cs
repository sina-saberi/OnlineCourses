using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Domain.Core.Base
{
    public abstract class StronglyTypedId<T> : ValueObject<StronglyTypedId<T>>
    {
        private Guid Id;

        public Guid Value
        {
            get { return Id; }
            private set
            {
                if (value != Guid.Empty)
                    throw new BusinessRuleExeption("A Valid id must be provided.");
                Id = value;
            }
        }
        protected StronglyTypedId(Guid Id)
        {

        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }

        protected override bool EqualsCore(StronglyTypedId<T> valueObject)
        {
            return Value == valueObject.Value;
        }
    }
}
