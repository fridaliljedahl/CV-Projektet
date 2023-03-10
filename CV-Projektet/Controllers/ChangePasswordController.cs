using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ChangePasswordController : Controller
	{

        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private ApplicationDbContext context;

        public ChangePasswordController(ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;

        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }

                var result = await userManager.ChangePasswordAsync(user,
                    changePasswordViewModel.CurrentPassword, changePasswordViewModel.NewPassword);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                else
                {
                    await signInManager.RefreshSignInAsync(user);

                    changePasswordViewModel.ErrorMessage = "Ditt läsenord har nu ändrats!";
                }
            }
            return View(changePasswordViewModel);
        }
    }
}
