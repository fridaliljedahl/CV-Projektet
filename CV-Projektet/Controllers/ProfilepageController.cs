using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ProfilepageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
