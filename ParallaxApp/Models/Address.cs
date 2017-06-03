using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class Address : IPersistentEntity
    {
        public Guid Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Guid UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
    }
}
