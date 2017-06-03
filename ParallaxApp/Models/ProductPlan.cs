using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class ProductPlan : IPersistentEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UnitItems { get; set; }
        public string ImageUrl { get; set; }
        public double PlanPrice { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
