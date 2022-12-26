using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Controllers
{
	public class ProjectsController : Controller
	{
		private ApplicationDbContext context;
		public ProjectsController(ApplicationDbContext cntx)
		{
			context = cntx;
		}
		public IActionResult Index(LoginViewModel loginViewModel)
		{
			List<Project> projectList = context.Projects.ToList();
			
			return View(projectList);

		}
	}
}
