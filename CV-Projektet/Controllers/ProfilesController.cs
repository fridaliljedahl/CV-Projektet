
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ProfilesController : Controller
	{
		private ApplicationDbContext context;
		public ProfilesController(ApplicationDbContext context)
		{
			this.context = context;
		}

        public IActionResult Index()
		{
			IEnumerable<User> users = context.Users.ToList();
			return View(users);
		}
        [HttpPost]
        public IActionResult Index(string firstName, string lastName, string competence, bool notUsed)
        {
            IEnumerable<User> users = context.Users.Where
				(u => u.FirstName.Equals(firstName) && u.LastName.Equals(lastName)).ToList();
            return View(users);
        }


    }
}
