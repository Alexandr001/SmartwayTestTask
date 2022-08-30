using Microsoft.AspNetCore.Mvc;

namespace SmartwayTestTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
