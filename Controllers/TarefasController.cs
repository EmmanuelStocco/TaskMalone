using Microsoft.AspNetCore.Mvc;

namespace ListaDeContatos.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
