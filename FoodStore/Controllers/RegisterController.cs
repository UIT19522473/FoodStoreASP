using FoodStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class RegisterController : Controller
    {
        // GET: RegisterController
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Submit(Customer customer)
        {

            return View();
        }
    }
}
