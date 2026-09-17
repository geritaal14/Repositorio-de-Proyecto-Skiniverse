using Microsoft.AspNetCore.Mvc;

namespace Skiniverse.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}