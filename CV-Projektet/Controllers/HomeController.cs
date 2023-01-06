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
            view.AllUsers = context.Users.OrderByDescending(u => u.RegistrationDate).Take(6).ToList();
            view.NonPrivateUsers = context.Users.OrderByDescending(u => u.RegistrationDate).Where(u => u.IsPublic == true).Take(6).ToList();
            view.Projects = context.Projects.OrderByDescending(p => p.CreatedDate).Take(6).ToList();
            return View(view);
        }
    }
}