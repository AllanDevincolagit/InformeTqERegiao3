using Microsoft.AspNetCore.Mvc;

namespace InformeTqERegiao.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Termos()
        {
            return View();
        }
    }
}
