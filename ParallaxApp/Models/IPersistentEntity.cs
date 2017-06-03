using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    interface IPersistentEntity
    {
        Guid Id { get; set; }
    }
}
