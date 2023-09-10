using ConecteDoe.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConecteDoe.WebApp.Controllers
{
    public class AutenticacaoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Autenticar(UsuarioViewModel entidade)
        {
            if (entidade.Autenticado())
                await Response.WriteAsync("Resultado Positivo");
            else
                await Response.WriteAsync("Resultado Negativo");
            return null;
        }
    }
}
