using Microsoft.AspNetCore.Mvc;

namespace ListaDeContatos.Controllers
{
    public class Tarefas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
