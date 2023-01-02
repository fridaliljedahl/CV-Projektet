using System.Linq;
using System.Xml.Linq;
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
			User? user = context.Users.Where(u => u.Id == userManager.GetUserId(User)).SingleOrDefault();
			CV? cv = context.CVs.Where(c => c.UserID == user.Id).SingleOrDefault();
			view.User = user;
			view.CV = cv;
			List<CV_Competences> competencesList = context.CV_Competences.ToList();
			List<int> competencesIDList = new List<int>();
			foreach (var item in competencesList)
			{
				if (item.CVID == cv.ID)
				{
					competencesIDList.Add(item.CompetenceID);
				}
			}
			view.CompetenceList = context.Competences.Where(c => competencesIDList.Contains(c.ID));
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
					addToList(competence, cv, competenceList, name);
				}
				else
				{
					List<CV_Competences> competencesList = context.CV_Competences.ToList();
					List<int> competencesIDList = new List<int>();
					foreach (var item in competencesList)
					{
						if (item.CVID == cv.ID)
						{
							competencesIDList.Add(item.CompetenceID);
						}
					}
					view.CompetenceList = context.Competences.Where(c => competencesIDList.Contains(c.ID));

					bool matchList = false;
					if (view.CompetenceList.Any())
					{
						foreach (var item in view.CompetenceList)
						{
							if (item.Name.Equals(name))
							{
								matchList = true;
							}
						}
						if (!matchList)
						{
							addToList(competence, cv, competenceList, name);
						}
						else
						{
							view.ErrorMessage = name + " finns redan i din lista!";
						}

					}
					else
					{
						addToList(competence, cv, competenceList, name);
					}
				}
			}
			catch (Exception ex)
			{
				view.ErrorMessage = name + " finns redan i din lista";
			}

			return RedirectToAction("Competence", "CVSettings", view);
		}
		public IActionResult EditExperience()
		{
			return View();
		}

		public void addToList(Competence competence, CV cv, CV_Competences competenceList, string name)
		{
			competence = context.Competences.Where(c => c.Name == name).Single();
			competenceList.CompetenceID = competence.ID;
			competenceList.CVID = cv.ID;
			context.CV_Competences.Add(competenceList);
			context.SaveChanges();
		}
	}
}

