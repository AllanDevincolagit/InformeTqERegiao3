using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformeTqERegiao.Entidades;

namespace InformeTqERegiao.Controllers
{
    public class ProblemaController : Controller
    {
        public IActionResult Feedback()
        {
            return View(lsInformeProblema);
        }

        public static List<ProblemaDialogocs> lsInformeProblema = new List<ProblemaDialogocs>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProblemaDialogocs objeto)
        {
            lsInformeProblema.Add(objeto);
            return RedirectToAction("Index");

        }
    }
}
