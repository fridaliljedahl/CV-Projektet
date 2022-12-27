using System.Net;
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Controllers
{
    public class CVController : Controller
    {
        private ApplicationDbContext context;
        public CVController(ApplicationDbContext cntx)
        {
            context = cntx;
        }

        [HttpGet]
        public IActionResult Index(string userID)
        {
            User? user = context.Users.Where(u => u.Id == userID).SingleOrDefault();
            var view = new CVDetails();
            if (user != null)
            {
                view.User = user;

                CV? cv = context.CVs.Where(c => c.UserID == user.Id).SingleOrDefault();

                if (cv != null)
                {
                    view.CV = cv;

                    List<User_Projects> projectsList = context.User_Projects.ToList();
                    List<int?> projectIDList = new List<int?>();
                    foreach (var item in projectsList)
                    {
                        if (item.UserID == user.Id)
                        {
                            projectIDList.Add(item.ProjectID);
                        }
                    }
                    view.ProjectList = context.Projects.Where(p => projectIDList.Contains(p.ID));

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

                    view.ExperienceList = context.Experiences.Where(e => e.CVID == cv.ID);
                }
                else
                {
                    view.CV = new CV();
                    view.ProjectList = new List<Project>();
                    view.CompetenceList = new List<Competence>();
                    view.ExperienceList = new List<Experience>();
                }
            }
            return View(view);
        }

		[HttpGet]
		public IActionResult Edit(string userID)
		{
			User? user = context.Users.Where(u => u.Id == userID).SingleOrDefault();
			var view = new CVDetails();
			if (user != null)
			{
				view.User = user;

				CV? cv = context.CVs.Where(c => c.UserID == user.Id).SingleOrDefault();

				if (cv != null)
				{
					view.CV = cv;

					List<User_Projects> projectsList = context.User_Projects.ToList();
					List<int?> projectIDList = new List<int?>();
					foreach (var item in projectsList)
					{
						if (item.UserID == user.Id)
						{
							projectIDList.Add(item.ProjectID);
						}
					}
					view.ProjectList = context.Projects.Where(p => projectIDList.Contains(p.ID));

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

					view.ExperienceList = context.Experiences.Where(e => e.CVID == cv.ID);
				}
				else
				{
					view.CV = new CV();
					view.ProjectList = new List<Project>();
					view.CompetenceList = new List<Competence>();
					view.ExperienceList = new List<Experience>();
				}
			}
			return View(view);
		}
	}
}
