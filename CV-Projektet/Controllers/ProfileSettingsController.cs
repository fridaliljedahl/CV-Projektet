using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

		//public IActionResult Submit()
		//{


		//	return RedirectToAction("Index", "Home");
  //      }

        [HttpPost]
        public IActionResult Edit(User userModel)
		{
            //var userToUpdate = context.Users.Where(u => u.Id == userManager.GetUserId(User)).SingleOrDefault();

            //context.Entry(userToUpdate).CurrentValues.SetValues(user);
            try
            {
                User user = context.Users.Find(userManager.GetUserId(User));
                user.UserName = userModel.UserName;
                user.Email = userModel.Email;
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.Description = userModel.Description;
                user.IsPublic = userModel.IsPublic;
                user.PhoneNumber = userModel.PhoneNumber;
                user.IsActive = userModel.IsActive;
                user.IsPublic = userModel.IsPublic;

                context.Users.Update(user);
                context.SaveChanges();


            }
            catch (DbUpdateConcurrencyException)
            {
            }
            return RedirectToAction("Index", "Home");

        }
    }
}