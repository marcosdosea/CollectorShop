using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace collectorShop.Controllers
{
    public class TesteController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Form()
        {
            return View();
        }

    }
}