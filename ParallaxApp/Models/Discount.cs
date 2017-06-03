using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public enum DiscountType
    {
        Product, Plan
    }

    public class Discount : IPersistentEntity
    {
        public Guid Id { get; set; }
        public double? Percentage { get; set; }
        public double? Amount { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidUntil { get; set; }
        public DiscountType DiscountType { get; set; }
        public Guid DiscountedItemId { get; set; }

    }
}
