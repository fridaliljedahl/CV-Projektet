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
		public IActionResult Index()
		{
			User ?user = context.Users.Where(u => u.Id == "användare1id").SingleOrDefault(); ;

            CV ?cv = context.CVs.Where(c => c.UserID == user.Id).SingleOrDefault();

			List<CV_Projects> projectsList = context.CV_Projects.ToList();
			List<int> projectIDList = new List<int>();
			foreach (var item in projectsList)
			{
				if(item.CVID == cv.ID)
				{
					projectIDList.Add(item.ProjectID);
				}				
			}
			IEnumerable<Project> projects = context.Projects.Where(p => projectIDList.Contains(p.ID));

			List<CV_Competences> competencesList = context.CV_Competences.ToList();
			List<int> competencesIDList = new List<int>();
            foreach (var item in competencesList)
            {
                if (item.CVID == cv.ID)
                {
                    competencesIDList.Add(item.CompetenceID);
                }
            }
            IEnumerable<Competence> competences = context.Competences.Where(c => competencesIDList.Contains(c.ID));

			IEnumerable<Experience> experiences = context.Experiences.Where(e => e.CVID == cv.ID);

			Address ?address = context.Addresses.Where(a => a.ID == user.AdressID).SingleOrDefault();

			var view = new CVDetails
			{
				CV = cv,
				User = user,
				Address = address,
				ProjectList = projects.ToList(),
				CompetenceList = competences.ToList(),
				ExperienceList = experiences.ToList()
			};

			return View(view);
		}

		}
}
