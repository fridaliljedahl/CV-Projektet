using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace CV_Projektet.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private ApplicationDbContext context;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
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
            try
            {
                if (ModelState.IsValid)
                {
                    User user = new User();
                    user.UserName = userRegistrationViewmodel.UserName;
                    user.Email = userRegistrationViewmodel.Email;
                    user.FirstName = userRegistrationViewmodel.FirstName;
                    user.LastName = userRegistrationViewmodel.LastName;
                    user.Description = userRegistrationViewmodel.Description;
                    user.IsPublic = userRegistrationViewmodel.IsPublic;
                    user.IsActive = true;
                    user.RegistrationDate = DateTime.Now;

                    var result = await userManager.CreateAsync(user, userRegistrationViewmodel.Password);
                    if (result.Succeeded)
                    {
                        User createdUser = context.Users.Where(u => u.UserName == user.UserName).Single();

                        Address address = new Address();
                        address.Street = userRegistrationViewmodel.Street;
                        address.City = userRegistrationViewmodel.City;
                        address.PostalCode = userRegistrationViewmodel.PostalCode;

                        Address addressExists = context.Addresses.Where(a =>
                            a.Street == address.Street &&
                            a.PostalCode == address.PostalCode &&
                            a.City == address.City)
                            .Single();

                        //if (addressExists == null)

                        context.Add(address);

                        Address addedAddres = context.Addresses.OrderByDescending(a => a.ID).First();
                        createdUser.AdressID = addedAddres.ID;
                        context.Users.Update(createdUser);

                        CV cv = new CV();
                        cv.UserID = createdUser.Id;
                        context.Add(cv);

                        context.SaveChanges();
                        await signInManager.SignInAsync(user, isPersistent: true);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        string errorMessage = "";
                        foreach (var item in result.Errors)
                        {
                            errorMessage += item.Description + " ";
                        }
                        userRegistrationViewmodel.returnedErrorMessage = errorMessage;
                    }
                }
            }
            catch (Exception ex) { }

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
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }

}
