using Microsoft.AspNetCore.Mvc;

namespace Skiniverse.Controllers
{
    public class ConsejosController : Controller
    {
        public IActionResult Detalle(string tipo)
        {
            ViewData["TipoPiel"] = tipo;
            return View();
        }
    }
}