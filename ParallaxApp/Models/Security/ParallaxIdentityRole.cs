using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models.Security
{
    public class ParallaxIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
