using System.Xml.Linq;
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
	public class ManagedProjectsController : Controller
	{
		private ApplicationDbContext context;
		private UserManager<User> userManager;
		private SignInManager<User> signInManager;
		public ManagedProjectsController(ApplicationDbContext context, UserManager<User> userMngr, SignInManager<User> signInMngr)
		{
			this.context = context;
			this.userManager = userMngr;
			this.signInManager = signInMngr;
		}
		public IActionResult Index()
		{
			TempData.Remove("Empty");
			TempData.Remove("NoUser");
			List<Project> projectList = context.Projects.OrderByDescending(p => p.CreatedDate).ToList();

			return View(projectList);
		}

		[HttpGet]
		public IActionResult Edit(Project view)
		{
			view = context.Projects.Find(view.ID);
			if (TempData.ContainsKey("Empty"))
			{
				ViewBag.Message = "Vänligen fyll i ett användarnamn";
			}
			if (TempData.ContainsKey("NoUser"))
			{
				ViewBag.Message = "Användarnamnet finns inte";
			}
			return View(view);
		}

		[HttpPost]
		public IActionResult Edit(Project view, int projectId)
		{
			Project project = context.Projects.Find(projectId);
			if (ModelState.IsValid)
			{
				if (view.Name != null && view.Description != null)
				{
					project.Name = view.Name;
					project.Description = view.Description;
					context.Projects.Update(project);
					context.SaveChanges();
				}
			}
			view = context.Projects.Find(projectId);
			return View(view);
		}

		[HttpPost]
		public IActionResult AddMembers(Project view, int projectId)
		{
			view = context.Projects.Find(projectId);
			TempData.Remove("Empty");
			TempData.Remove("NoUser");
			try
			{
				if (Request.Form["UserName"].ToString() != "")
				{
					User user = context.Users.Where(u => u.UserName == Request.Form["UserName"].ToString()).SingleOrDefault();
					if (user != null)
					{
						User_Projects userproj = new User_Projects();

						userproj.ProjectID = view.ID;
						userproj.UserID = user.Id;
						context.Add(userproj);
						context.SaveChanges();
						TempData["NoMessage"] = "";
					}
					else
					{
						TempData["NoUser"] = "Användarnamnet finns inte!";
					}
				}
				else
				{
					TempData["Empty"] = "Vänligen fyll i ett användarnamn!";
				}
			}

			catch (Exception ex)
			{
			}
			return RedirectToAction("Edit", "ManagedProjects", view);
		}
		public IActionResult DeleteFromProject(Project view, string userId, int projectId)
		{
			view = context.Projects.Find(projectId);
			try
			{
				User user = context.Users.Find(userId);

				if (user != null)
				{
					User_Projects userproj = new User_Projects();
					userproj.ProjectID = view.ID;
					userproj.UserID = user.Id;
					context.User_Projects.Remove(userproj);
					context.SaveChanges();
				}
			}

			catch (Exception ex)
			{
				ViewBag.ErrorMessage = "Användaren hittades inte";
			}

			return RedirectToAction("Edit", "ManagedProjects", view);
		}

		public IActionResult Delete(Project view, int projectId)
		{
			var project = context.Projects.Find(projectId);
			List<User_Projects> userProject = context.User_Projects.Where(p => p.ProjectID == projectId).ToList();
			context.Projects.Remove(project);
			if (userProject != null)
			{
				foreach (var item in userProject)
				{
					context.User_Projects.Remove(item);
				}
			}
			context.SaveChanges();
			return RedirectToAction("Index", "ManagedProjects", view);
		}
	}
}
