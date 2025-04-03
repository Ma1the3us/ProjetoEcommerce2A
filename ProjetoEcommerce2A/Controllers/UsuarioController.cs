using Microsoft.AspNetCore.Mvc;

namespace ProjetoEcommerce2A.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
