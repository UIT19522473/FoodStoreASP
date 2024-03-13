using FoodStore.Data;
using FoodStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Controllers
{
    public class RegisterController : Controller
    {

        private readonly FoodStoreContext _context;

        public RegisterController(FoodStoreContext context)
        {
            _context = context;
        }


        // GET: RegisterController
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SubmitAsync(Customer customer)
        {
            var customerInDb = await _context.Customer.FirstOrDefaultAsync(cus => cus.Email == customer.Email);

            if (customerInDb == null)
            {
                // Khong tim thấy khách hàng trong cơ sở dữ liệu, thực hiện các thao tác cần thiết
                customerInDb = new Customer {
                    Email = customer.Email,
                    Name = customer.Name,
                    Password = customer.Password 
                
                };
                _context.Customer.Add(customerInDb);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Login");
            }
            return View("Index");
        }
    }
}
