using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ProfilesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
