using OnlineCourses.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Domain.Core.Catalogs.Categories
{
    public class Feature : Entity<Guid>
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public int SortOrder { get; set; }

        internal static Feature CreateNew(string title, string description, int sortOrder)
        {
            return new Feature(title, description, sortOrder);
        }

        private Feature(string title, string description, int sortOrder)
        {
            this.Title = title;
            this.Description = description;
            this.SortOrder = sortOrder;
        }
        private Feature() { }
    }
}
