using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParallaxApp.Models.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Data.Security
{
    public class ParallaxIdentityDbContext : IdentityDbContext<ParallaxIdentityUser, ParallaxIdentityRole, string>
    {
        public ParallaxIdentityDbContext(DbContextOptions<ParallaxIdentityDbContext> options)
            : base(options) 
        {

        }
    }
}
