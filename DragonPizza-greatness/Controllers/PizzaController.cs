using Microsoft.AspNetCore.Mvc;

namespace DragonPizza_greatness.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
