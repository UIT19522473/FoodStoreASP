using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
