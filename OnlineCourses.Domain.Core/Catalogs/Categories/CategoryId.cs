using OnlineCourses.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Domain.Core.Catalogs.CateGories
{
    public sealed class CategoryId : StronglyTypedId<CategoryId>
    {
        public CategoryId(Guid value) : base (value) 
        {

        }
    }
}
