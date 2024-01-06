using FoodStore.Data;
using FoodStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;

namespace FoodStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly FoodStoreContext _context;

        public HomeController(FoodStoreContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1: page.Value;

            var categoriesCtx = await(_context.Category).ToListAsync();
            /*          var dishesCtx = await (_context.Dish.Include(d => d.Category)).ToListAsync();*/
            /*            ViewBag.dishes = dishesCtx;
                        ViewBag.categories = categoriesCtx;
                        return View();*/

            var dishesCtx = _context.Dish.AsNoTracking().OrderBy(x => x.Id);
            PagedList<Dish> dishes = new PagedList<Dish>(dishesCtx, pageNumber, pageSize);
            ViewBag.dishes = dishes;
            ViewBag.categories = categoriesCtx;

            return View(dishes);

            /*          var foodStoreContext = _context.Dish.Include(d => d.Category);
                      return View(await foodStoreContext.ToListAsync());*/

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
