using Microsoft.AspNetCore.Mvc;

namespace MessageWebAPI.Models
{
	public class Profilepage : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
