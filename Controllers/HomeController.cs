using intex.Data;
using intex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace intex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //private IMummyRepository repo;
        //private ITextileRepository repot;
        //private IColorRepository repoc;

        //public HomeController (IMummyRepository m, ITextileRepository t, IColorRepository c, ILogger<HomeController> logger, ApplicationDbContext temp)
        //{
        //    repo = m;
        //    repot = t;
        //    repoc = c;
        //    _logger = logger;
        //    context = temp;
        //}

        //private readonly ILogger<HomeController> _logger;
        
        //private ApplicationDbContext context { get; set; }

        //public IActionResult Index()
        //{
        //    ViewBag.ShowTopBar = false;
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult AddRecord()
        //{
        //    return View("AddRecord", new mummy());
        //}

        //[HttpPost]
        //public IActionResult AddRecord(mummy mum)
        //{
        //    // if (ModelState.IsValid)
        //    // {
        //    context.Add(mum);
        //    context.SaveChanges();
        //    return View("RecordConfirmation", mum);
        //    // }

        //    // else
        //    // {
        //        // ViewBag.burialmain = MummyContext.burialmain.ToList();
        //        // return View();
        //    // }
        //}

        //[HttpGet]
        //public IActionResult EditRecord(int id)
        //{
        //    ViewBag.burialmain = context.burialmain.ToList();
        //    var submission = context.burialmain.Single(x => x.id == id);
        //    return View("AddRecord", submission);
        //}

        //[HttpPost]
        //public IActionResult EditRecord(mummy mum)
        //{
        //    context.Update(mum);
        //    context.SaveChanges();
        //    return RedirectToAction("BurialRecords");
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var submission = context.burialmain.Single(x => x.id == id);
        //    return View(submission);
        //}

        //[HttpPost]
        //public IActionResult Delete(mummy mum)
        //{
        //    context.burialmain.Remove(mum);
        //    context.SaveChanges();
        //    return RedirectToAction("BurialRecords");
        //}


        //public IActionResult BurialRecords()
        //{
        //    ViewBag.burialmain = repo.mummies
        //        //.Join(repoc)
        //        .OrderBy(m => m.area)
        //        .Take(5);
        //    //ViewBag.textile = repot.textiles.ToList();
        //    //ViewBag.color = repoc.colors.ToList();
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}