using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class Purchase : IPersistentEntity
    {
        public Guid Id { get; set; }
        public DateTime PurchaseDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
