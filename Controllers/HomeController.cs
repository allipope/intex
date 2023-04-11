using intex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace intex.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private MummyContext context { get; set; }

        public HomeController(MummyContext temp) => context = temp;

        public IActionResult Index()
        {
            ViewBag.ShowTopBar = false;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BurialRecords()
        {
            var blah = context.burialmain.ToList();
            return View(blah);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}