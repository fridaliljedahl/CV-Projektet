using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace CV_Projektet.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            LoginViewModel logInViewModel = new LoginViewModel();
            return View(logInViewModel);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
