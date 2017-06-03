using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class ShoppingCart
    {
        public ICollection<OrderItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsEmpty
        {
            get
            {
                return this.Items.Count == 0;
            }
        }
    }
}
