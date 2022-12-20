using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ProjectsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
