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
			var imageModel = await context.Images.FirstOrDefaultAsync(m => m.ID == id);
			if (imageModel == null)
			{
				return NotFound();
			}

			return View(imageModel);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Add([Bind("ID,Title,ImageFile")] ImageModel imageModel)
		{

			string wwwRootPath = _hostEnviroment.WebRootPath;
			string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
			string extension = Path.GetExtension(imageModel.ImageFile.FileName);
			imageModel.Name = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
			string path = Path.Combine(wwwRootPath + "/Image/", fileName);
			using (var fileStream = new FileStream(path, FileMode.Create))
			{
				await imageModel.ImageFile.CopyToAsync(fileStream);
			}

			context.Add(imageModel);
			await context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Name")] ImageModel imageModel)
		{
			if (imageModel == null)
			{
				return NotFound();
			}
			try
			{
				context.Update(imageModel);
				await context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				
			}
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var imageModel = await context.Images.FirstOrDefaultAsync(m => m.ID == id);
			if (imageModel == null)
			{
				return NotFound();
			}
			return View(imageModel);

		}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var imageModel = await context.Images.FindAsync(id);
			
			var imagePath = Path.Combine(_hostEnviroment.WebRootPath, "image", imageModel.Name);
			if (System.IO.File.Exists(imagePath))
			{
				System.IO.File.Delete(imagePath);
			}

			context.Images.Remove(imageModel);
			await context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));	
		}

		private bool ImageModelExists(int id)
		{
			return context.Images.Any(e => e.ID == id);
		}
	}
}
