using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ManagedProjectsController : Controller
	{
		private ApplicationDbContext context;
		public ManagedProjectsController(ApplicationDbContext context)
		{
			this.context = context;
		}
		public IActionResult Index()
		{
			List<Project> projectList = context.Projects.OrderByDescending(p => p.CreatedDate).ToList();

			return View(projectList);
		}


		public IActionResult Edit(Project view, int id)
		{
			 view = context.Projects.Find(id);

			return View(view);
		}
		
		public IActionResult Delete()
		{
			return View();
		}
	}
}
