using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
