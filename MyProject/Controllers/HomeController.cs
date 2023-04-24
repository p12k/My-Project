using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Diagnostics;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Formrezaor(DataModel dataModel)
        {

            return RedirectToAction("Index");
        }
        public IActionResult DataPractice(DataModel dataModel)
        {
            
            return RedirectToAction("Index");//form Model ke through data laana
        }

        public IActionResult Dataupload(DataModel dataModel)
        {

            return RedirectToAction("Index");//form Model ke through data laana
        }
        [HttpPost]
        public IActionResult DataAjax(PracticeModel practiceModel)
        {

         
            // return RedirectToAction("Index");//javascript ,Ajax ke through data laana
           return PartialView("_Index1");
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