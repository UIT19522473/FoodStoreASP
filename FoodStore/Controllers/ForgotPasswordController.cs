using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
