using Microsoft.AspNetCore.Mvc;
using ProjetoEcommerce2A.Repositorio;

namespace ProjetoEcommerce2A.Controllers
{
    public class UsuarioController : Controller
    {
        //ele esta inicializando o seu repositorio usuario, ele é construtor
        private readonly UsuarioRepositorio _usuarioRepositorio;
      
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario =_usuarioRepositorio.ObterUsuario(email);
            if (usuario != null && usuario.Senha == senha)
            {
                // Autenticação bem-sucedida
                return RedirectToAction("Index", "Cliente");
            }
            ModelState.AddModelError("", "Email ou senha inválidos.");
            return View();
        }
    }
}
