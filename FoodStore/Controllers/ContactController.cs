using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
