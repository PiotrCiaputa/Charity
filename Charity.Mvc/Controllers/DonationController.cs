using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Charity.Mvc.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donate(Donation donation)
        {
            return View();
        }
    }
}
