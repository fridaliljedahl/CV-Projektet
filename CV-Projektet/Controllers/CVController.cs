using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class CVController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
