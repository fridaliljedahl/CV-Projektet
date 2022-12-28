using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Models
{
	public class Profilepage : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
