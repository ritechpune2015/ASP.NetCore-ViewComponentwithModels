using Microsoft.AspNetCore.Mvc;

namespace ViewComponentEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
