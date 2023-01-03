using System.Linq;
using System.Xml.Linq;
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
					if (item.Name.ToLower().Equals(name.ToLower()))
					{
						matchDB = true;
					}
				}
				if (!matchDB)
				{
					competence.Name = name;
					context.Add(competence);
					context.SaveChanges();
					addToListCompetence(competence, cv, competenceList, name);
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
							if (item.Name.ToLower().Equals(name.ToLower()))
							{
								matchList = true;
							}
						}
						if (!matchList)
						{
							addToListCompetence(competence, cv, competenceList, name);
						}
						else
						{
							view.ErrorMessage = name + " finns redan i din lista!";
						}

					}
					else
					{
						addToListCompetence(competence, cv, competenceList, name);
					}
				}
			}
			catch (Exception ex)
			{
				view.ErrorMessage = name + " finns redan i din lista";
			}

			return RedirectToAction("Competence", "CVSettings", view);
		}
		public IActionResult DeleteCompetence(CVDetails view, int ID)
		{
			var competence = context.Competences.Find(ID);
			User user = context.Users.Find(userManager.GetUserId(User));
			CV? cv = context.CVs.Where(c => c.UserID == userManager.GetUserId(User)).SingleOrDefault();
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
			CV_Competences competenceList = new CV_Competences();
			competenceList.CompetenceID = competence.ID;
			competenceList.CVID = cv.ID;
			context.Competences.Remove(competence);
			context.CV_Competences.Remove(competenceList);
			context.SaveChanges();
			return RedirectToAction("Competence", "CVSettings", view);
		}
		public IActionResult EditExperience()
		{
			return View();
		}

		public void addToListCompetence(Competence competence, CV cv, CV_Competences competenceList, string name)
		{
			competence = context.Competences.Where(c => c.Name == name).Single();
			competenceList.CompetenceID = competence.ID;
			competenceList.CVID = cv.ID;
			context.CV_Competences.Add(competenceList);
			context.SaveChanges();
		}

		public IActionResult Education(CVDetails view)
		{
			User? user = context.Users.Where(u => u.Id == userManager.GetUserId(User)).SingleOrDefault();
			CV? cv = context.CVs.Where(c => c.UserID == user.Id).SingleOrDefault();
			view.User = user;
			view.CV = cv;
			view.ExperienceList = context.Experiences.Where(e => e.CVID == cv.ID);
			return View(view);
		}
		public IActionResult AddEducation(CVDetails view, string title, string type, DateTime startDate, DateTime endDate, string city, string place, string description)
		{			
			CV? cv = context.CVs.Where(c => c.UserID == userManager.GetUserId(User)).SingleOrDefault();
			view.ExperienceList = context.Experiences.Where(e => e.CVID == cv.ID);
			Experience experience = new Experience();

			try
			{
				bool matchDB = false;
				foreach (var item in context.Experiences)
				{
					if (item.Title.ToLower().Equals(title.ToLower()) && item.Type.ToLower().Equals(type.ToLower()) && item.StartDate.Equals(startDate) && item.EndDate.Equals(endDate) && item.City.ToLower().Equals(city.ToLower()) && item.Description.ToLower().Equals(description.ToLower()))
					{
						matchDB = true;
					}
				}
				if (!matchDB)
				{
					experience.Title = title;
					experience.Type = type;
					experience.StartDate = startDate;
					experience.EndDate = endDate;
					experience.City = city;
					experience.Description = description;
					context.Add(experience);
					context.SaveChanges();
					experience = context.Experiences.Where(e => e.Title == title && e.Type == type && e.City == city).Single();
					context.Experiences.Add(experience);
					context.SaveChanges();
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
							if (item.Name.ToLower().Equals(name.ToLower()))
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

		public IActionResult Course()
		{
			return View();
		}
		public IActionResult AddCourse()
		{
			return View();
		}

		public IActionResult Misc()
		{
			return View();
		}
		public IActionResult AddMisc()
		{
			return View();
		}

		public IActionResult Work()
		{
			return View();
		}
		public IActionResult AddWork()
		{
			return View();
		}
	}
}

