using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public abstract class PaymentMethod : IPersistentEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
    }
}
