using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace CV_Projektet.Controllers
{
	public class ProfileSettingsController : Controller
	{
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private ApplicationDbContext context;

		public ProfileSettingsController(ApplicationDbContext context, UserManager <User> userManager, SignInManager<User> signInManager)
		{
			this.context = context;
			this.userManager = userManager;
			this.signInManager = signInManager;
		}
        public IActionResult Index()
		{
			User? user = context.Users.Where(u => u.Id == userManager.GetUserId(User)).SingleOrDefault();
			return View(user);
		}
	}
}