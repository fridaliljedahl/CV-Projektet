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

        [HttpPost]
        public async Task<IActionResult> Register(UserRegistrationViewModel userRegistrationViewmodel)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.UserName= userRegistrationViewmodel.UserName;
              
                var result = await userManager.CreateAsync(user, userRegistrationViewmodel.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: true);
                    return RedirectToAction("Index", "Home");
                }
            }
			return View(userRegistrationViewmodel);
		}

		[HttpPost]
		public async Task<IActionResult> LogIn(LoginViewModel loginViewModel)
		{
			if (ModelState.IsValid)
			{
				var result = await signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password,
					isPersistent: loginViewModel.RememberMe, lockoutOnFailure: false);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}

			}
			return View(loginViewModel);
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Loggaut()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}

}
