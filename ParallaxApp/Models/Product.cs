using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class Product : IPersistentEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; }

        public ProductInformation ProductInfo { get; set; }
        public ICollection<ProductPlan> ProductPlans { get; set; }
    }
}
