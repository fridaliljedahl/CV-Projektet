using Castle.Core.Internal;
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Controllers
{
	public class ProjectsController : Controller
	{
		private ApplicationDbContext context;
		private UserManager<User> userManager;
		private SignInManager<User> signInManager;
		public ProjectsController(ApplicationDbContext cntx, UserManager<User> userMngr, SignInManager<User> signInMngr)
		{
			context = cntx;
			this.userManager = userMngr;
			this.signInManager = signInMngr;
		}
		public IActionResult Index(LoginViewModel loginViewModel)
		{
			List<Project> projectList = context.Projects.OrderByDescending(p => p.CreatedDate).ToList();

			return View(projectList);
		}

		[HttpGet]
		public IActionResult CreateProject()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateProject(CreateProjectViewModel view)
		{
			try
			{
				if (ModelState.IsValid)
				{
					User user = context.Users.Find(userManager.GetUserId(User));
					

					Project project = new Project();
					if (!user.Id.IsNullOrEmpty())
					{
						project.ProjectLeaderID = user.Id;
					}
					project.Name = view.Name;
					project.Description = view.Description;
					DateTime dt = DateTime.Now;
					project.CreatedDate = dt;
					context.Projects.Add(project);
					context.SaveChanges();

					Project proj = context.Projects.Where(p => p.Name == view.Name && p.Description == view.Description && p.CreatedDate == dt).Single();

					AddProjectMembersViewModel nextView = new AddProjectMembersViewModel();
					nextView.Project = proj;

					return RedirectToAction("AddProjectMembers", "Projects", new { id = proj.ID });
				}
			}
			catch (Exception ex)
			{
				view.ErrorMessage = "Någon person med anviget användarnamn hittades inte.";
			}
			return View(view);
		}

		public IActionResult AddProjectMembers(int id, AddProjectMembersViewModel view)
		{
			view.ErrorMessage = "";
			Project proj = context.Projects.Find(id);
			view.Project = proj;
			view.Id = id;
			try
			{
				User user = context.Users.Where(u => u.UserName == view.UserName).Single();
				if (user != null)
				{
					User_Projects userproj = new User_Projects();
					userproj.ProjectID = proj.ID;
					userproj.UserID = user.Id;
					context.Add(userproj);
					context.SaveChanges();
				}
			}

			catch (Exception ex)
			{
				view.ErrorMessage = "Användaren hittades inte";
			}

			return View(view);
		}
	}
}
