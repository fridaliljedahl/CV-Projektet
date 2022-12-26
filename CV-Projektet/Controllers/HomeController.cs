using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CV_Projektet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext cntx)
        {
            _logger = logger;
            context = cntx;
        }

        public IActionResult Index()
        {
            var view = new HomeViewModel();
            view.Users = context.Users.OrderByDescending(u => u);
            return View();
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