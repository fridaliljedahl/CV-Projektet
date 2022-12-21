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
			CV cv = context.CVs.Where(c => c.ID == 1).SingleOrDefault();
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

			var view = new CVDetails
			{
				ID = cv.ID,
				TimesViewed = cv.TimesViewed,
				ProjectList = projects.ToList()
			};


			return View(view);
		}
		//public ActionResult Details(int? id)
		//{
		//	if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }
		}
}
