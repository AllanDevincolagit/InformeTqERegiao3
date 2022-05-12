using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Farmacias()
        {
            return View();
        }

        public IActionResult Hospitais()
        {
            return View();
        }

        public IActionResult Supermercados()
        {
            return View();
        }
    }
}
