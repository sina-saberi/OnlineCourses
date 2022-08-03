using OnlineCourses.Domain.Core.Base;
using OnlineCourses.Domain.Core.Catalogs.CateGories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Domain.Core.Catalogs.Categories
{
    public class Category : AggregateRoot<CategoryId>
    {
        public string CategoryName { get; set; }

        public bool IsActive { get; set; }

        public string Description { get; set; }

        public IReadOnlyList<Feature> Feature => _features;

        private readonly List<Feature> _features = new List<Feature>();

        internal static Category CreateNew(string categoryName, string isActive, string description, List<FeatureData> features)
        {
            return new Category(categoryName, isActive, description, features);
        }


        private void GenerateFeatures(List<FeatureData> features)
        {
            features.ForEach(item =>
            {
                var newFeature = Categories.Feature.CreateNew(item.Title, item.Description, item.SortOrder);
                _features.Add(newFeature);
            });
        }

        private Category(string categoryName, string isActive, string description, List<FeatureData> features)
        {
            this.CategoryName = categoryName;
            this.IsActive = IsActive;
            this.Description = description;
            GenerateFeatures(features);
        }

        private Category()
        {

        }
    }
}
