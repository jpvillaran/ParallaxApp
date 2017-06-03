using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class OrderItem : IPersistentEntity
    {
        public Guid Id { get; set; }
        public int Units { get; set; }

        public Guid ProductPlanId { get; set; }
        public Guid PurchaseId { get; set; }

        public ProductPlan ProductPlan { get; set; }
        public Purchase Purchase { get; set; }
    }
}
