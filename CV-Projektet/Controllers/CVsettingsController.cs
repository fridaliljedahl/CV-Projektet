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
			List<CV_Competences> competences = context.CV_Competences.ToList();
			//List<int> competencesIDList = new List<int>();
			Competence competence = new Competence();
			CV? cv = context.CVs.Where(c => c.UserID == userManager.GetUserId(User)).SingleOrDefault();
			CV_Competences competenceList = new CV_Competences();
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
					competence.Name = name;
					context.Add(competence);
					context.SaveChanges();
				}
			}
			catch (Exception ex) { }
			try
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
						if (!matchList)
						{
							competence = context.Competences.Where(c => c.Name == name).Single();
							competenceList.CompetenceID = competence.ID;
							competenceList.CVID = cv.ID;
							context.CV_Competences.Add(competenceList);
							context.SaveChanges();
						}
					}
				}
			}
			catch (Exception ex)
			{
				competence = context.Competences.Where(c => c.Name == name).Single();
				competenceList.CompetenceID = competence.ID;
				competenceList.CVID = cv.ID;
				context.CV_Competences.Add(competenceList);
				context.SaveChanges();
			}
			return RedirectToAction("Competence", "CVSettings", view);
		}
		public IActionResult EditExperience()
		{
			return View();
		}
	}
}

