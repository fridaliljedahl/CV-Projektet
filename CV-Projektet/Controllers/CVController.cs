using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;

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
			List<CV> CVlist = context.CVs.ToList();
			return View(CVlist);
		}
	}
}
