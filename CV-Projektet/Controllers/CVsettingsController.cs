using System.Linq;
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class CVsettingsController : Controller
	{
		private ApplicationDbContext context;
		private UserManager<User> userManager;
		private SignInManager<User> signInManager;
		public CVsettingsController(ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
		{
			this.context = context;
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

		public IActionResult Competence(CVDetails view)
		{
			return View(view);
		}

		public IActionResult Experience()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCompetence(CVDetails view, string name)
		{
			List<CV_Competences> competencesList = context.CV_Competences.ToList();
			List<int> competencesIDList = new List<int>();

			try
			{
				bool matchDB = false;
				foreach (var item in context.Competences)
				{
					if (item.Name.Equals(name))
					{
						matchDB = true;
					}
				}
				if (!matchDB)

				{
					Competence competence = new Competence();
					competence.Name = name;
					context.Add(competence);
					//kontrollera om kompetens finns i databasen
					CV_Competences cb = new CV_Competences();
					//sambandtabellen behöver ett sambandsobjekt när man lägger in det
					//cb.CompetenceID = context.Competences.Where(hämta via namn);
					// ........ .cvID
					//context.CV_Competences.Add(competence)
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				if (view.CompetenceList.Any())
				{
					bool matchList = false;
					foreach (var item in view.CompetenceList)
					{
						if (item.Name.Equals(name))
						{
							matchList = true;
						}
					}
				}
			}
			return RedirectToAction("Competence", "CVSettings", view);
		}
		public IActionResult EditExperience()
		{
			return View();
		}
	}
}

