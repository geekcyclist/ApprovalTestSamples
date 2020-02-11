using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collatz.AspCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Collatz.AspCoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CollatzSeriesViewModel {StartValue = 0};
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(CollatzSeriesViewModel model)
        {
            //var model = new CollatzSeriesViewModel {StartValue = startValue};
            model.Populate();
            return View(model);
        }
    }
}