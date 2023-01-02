using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace CV_Projektet.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private ApplicationDbContext context;
        private HttpClient client;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context, HttpClient client)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
            this.client = client;
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
                    user.PhoneNumber = userRegistrationViewmodel.PhoneNumber;
                    user.IsActive = true;
                    user.RegistrationDate = DateTime.Now;

                    var result = await userManager.CreateAsync(user, userRegistrationViewmodel.Password);
                    if (result.Succeeded)
                    {
                        User createdUser = context.Users.Where(u => u.UserName == user.UserName).Single();

                        Address? enteredAddress = context.Addresses.Where(a =>
                            a.Street == userRegistrationViewmodel.Street &&
                            a.PostalCode == int.Parse(userRegistrationViewmodel.PostalCode) &&
                            a.City == userRegistrationViewmodel.City)
                            .SingleOrDefault();

                        if (enteredAddress == null)
                        {
                            enteredAddress = new Address();
                            enteredAddress.Street = userRegistrationViewmodel.Street;
                            enteredAddress.City = userRegistrationViewmodel.City;
                            enteredAddress.PostalCode = int.Parse(userRegistrationViewmodel.PostalCode);
                            context.Add(enteredAddress);
                            context.SaveChanges();
                            enteredAddress = context.Addresses.OrderByDescending(a => a.ID).First();
                        }

                        createdUser.AdressID = enteredAddress.ID;
                        context.Users.Update(createdUser);
                        context.SaveChanges();

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
                else
                {
                    loginViewModel.ErrorMessage = "Inloggning misslyckades. Kontrollera användarnamn och lösenord och försök igen.";
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

        public async Task<IActionResult> MyMessages()
        {
            string route = client.BaseAddress + "receiver/" + userManager.GetUserId(User);
            HttpResponseMessage response = await client.GetAsync(route);
            string data = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        
            List<Message>? messages = JsonSerializer.Deserialize<List<Message>>(data, options)
                .OrderBy(m => m.Date).ToList();
            return View(messages);
        }

        public IActionResult SetReadState(int messageId)
        {
            Message msg = context.Messages.Find(messageId);
            msg.Read = !msg.Read;
            context.Messages.Update(msg);
            context.SaveChanges();
            return RedirectToAction("MyMessages", "Account");
        }

    }
}
