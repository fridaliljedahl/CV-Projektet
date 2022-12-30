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
            UserRegistrationViewModel viewModel = new UserRegistrationViewModel();

            viewModel.UserName = user.UserName;
            viewModel.FirstName = user.FirstName;
            viewModel.Password = user.PasswordHash;
            viewModel.PasswordConfirmed = user.PasswordHash;
            viewModel.FirstName = user.FirstName;
            viewModel.LastName = user.LastName;
            viewModel.Description = user.FirstName;
            viewModel.Email = user.Email;
            viewModel.IsPublic = user.IsPublic;
            viewModel.PhoneNumber = user.PhoneNumber;
            

            if (user.Address != null)
                {
                    viewModel.Street = user.Address.Street;
                    viewModel.PostalCode = user.Address.PostalCode.ToString();
                    viewModel.City = user.Address.City;
                }
            return View(viewModel);
		}

		//public IActionResult Submit()
		//{


		//	return RedirectToAction("Index", "Home");
  //      }

        [HttpPost]
        public IActionResult Edit(UserRegistrationViewModel userModel)
		{
            //var userToUpdate = context.Users.Where(u => u.Id == userManager.GetUserId(User)).SingleOrDefault();

            //context.Entry(userToUpdate).CurrentValues.SetValues(user);
            try
            {
                User user = context.Users.Find(userManager.GetUserId(User));
                user.UserName = userModel.UserName;
                user.NormalizedUserName = userModel.UserName.ToUpper();
                user.Email = userModel.Email;
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.Description = userModel.Description;
                user.IsPublic = userModel.IsPublic;
                user.PhoneNumber = userModel.PhoneNumber;
                

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