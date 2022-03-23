using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
