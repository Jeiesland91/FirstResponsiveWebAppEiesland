using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppEiesland.Models;

namespace FirstResponsiveWebAppEiesland.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FirstResponsiveModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Age = 0;
            }

            return View(model);
        }
    }
}
