using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Controllers
{
	public class ImageController : Controller
	{
		private readonly ApplicationDbContext context;
		private readonly IWebHostEnvironment _hostEnviroment;

		public ImageController(ApplicationDbContext context, IWebHostEnvironment hostEnviroment)
		{
			this.context = context;
			_hostEnviroment = hostEnviroment;
		}

		public async Task<IActionResult> Index()
		{
			return View(await context.Images.ToListAsync());
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var image = await context.Images.FirstOrDefaultAsync(m => m.ID == id);
			if (image == null)
			{
				return NotFound();
			}

			return View(image);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Add([Bind("Title,ImageFile")] ImageModel imageModel)
		{
			if (ModelState.IsValid)
			{
				string wwwRootPath = _hostEnviroment.WebRootPath;
				string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
				string extension = Path.GetExtension(imageModel.ImageFile.FileName);
				imageModel.Name=fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
				string path = Path.Combine(wwwRootPath + "/Image/", fileName);
				using (var fileStream = new FileStream(path,FileMode.Create))
				{
					await imageModel.ImageFile.CopyToAsync(fileStream);
				}

				context.Add(imageModel);
				await context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(imageModel);
		}
	}
}
