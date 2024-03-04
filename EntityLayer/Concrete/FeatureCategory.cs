using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FeatureCategory
    {
        public int FeatureCategoryId { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string CategoryUrl { get; set; }
    }
}
