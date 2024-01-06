using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
