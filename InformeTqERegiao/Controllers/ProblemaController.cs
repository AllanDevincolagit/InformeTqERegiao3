using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformeTqERegiao.Models;

namespace InformeTqERegiao.Controllers
{
    public class ProblemaController : Controller
    {
        public IActionResult Feedback()
        {
            return View(lsInformeProblema);
        }

        public static List<InformeProblema> lsInformeProblema = new List<InformeProblema>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(InformeProblema objeto)
        {
            lsInformeProblema.Add(objeto);
            return RedirectToAction("Index");

        }
    }
}
