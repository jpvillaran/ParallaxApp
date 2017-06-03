using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Controllers
{
    public class CheckoutController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
