using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
