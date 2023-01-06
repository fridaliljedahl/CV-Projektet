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
            viewModel.LastName = user.LastName;
            viewModel.Description = user.Description;
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


        [HttpPost]
        public IActionResult Edit(UserRegistrationViewModel userModel)
		{
            UserRegistrationViewModel viewModel = new UserRegistrationViewModel();

            try
            {
                User user = context.Users.Find(userManager.GetUserId(User));
                Address address = context.Addresses.Find(user.AdressID);
                user.UserName = userModel.UserName;
                user.NormalizedUserName = userModel.UserName.ToUpper();
                user.Email = userModel.Email;
                user.NormalizedEmail = userModel.Email.ToUpper();
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.Description = userModel.Description;
                user.IsPublic = userModel.IsPublic;
                user.PhoneNumber = userModel.PhoneNumber;
                address.Street = userModel.Street;
                address.PostalCode = int.Parse(userModel.PostalCode);
                address.City = userModel.City;


                context.Addresses.Update(address);
                context.Users.Update(user);
                context.SaveChanges();

            }
            catch (Exception ex){}
            return RedirectToAction("Index", "ProfileSettings");

        }
    }
}