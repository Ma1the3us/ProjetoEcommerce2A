using Microsoft.AspNetCore.Mvc;

namespace ProjetoEcommerce2A.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
