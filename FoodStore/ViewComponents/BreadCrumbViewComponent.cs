using Microsoft.AspNetCore.Mvc;

namespace FoodStore.ViewComponents
{
    public class BreadCrumbViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke( string name)
                                      
        {
            return View("Default",name);
        }
    }
}
