
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CV_Projektet.Controllers
{
    public class ProfilesController : Controller
    {
        private ApplicationDbContext context;
        public ProfilesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(string fName, string lName)
        {
            IEnumerable<User> users = context.Users.ToList();

            if (!string.IsNullOrWhiteSpace(fName) && !string.IsNullOrWhiteSpace(lName))
            {
                users = context.Users.Where(u => u.FirstName.StartsWith(fName) && u.LastName.StartsWith(lName));
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(fName))
                {
                    users = context.Users.Where(u => u.FirstName.StartsWith(fName));
                }
                if (!string.IsNullOrWhiteSpace(lName))
                {
                    users = context.Users.Where(u => u.LastName.StartsWith(lName));
                }
            }

            return View(users.ToList());
        }
    }
}
