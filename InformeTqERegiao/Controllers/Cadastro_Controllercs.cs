using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InformeTqERegiao.Controllers
{
    public class Cadastro : Controller
    {

        private readonly Contexto db;

        public Cadastro(Contexto _db)
        {
            db = _db;
        }

        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cadastro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cadastro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cadastro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cadastro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cadastro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cadastro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
