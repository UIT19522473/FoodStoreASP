using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
