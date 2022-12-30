using Castle.Core.Internal;
using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CV_Projektet.Controllers
{
    public class ProjectsController : Controller
    {
        private ApplicationDbContext context;
        public ProjectsController(ApplicationDbContext cntx)
        {
            context = cntx;
        }
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            List<Project> projectList = context.Projects.ToList();

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
                    User user = new User();
                    if (view.ProjectLeaderUserName != null)
                    {
                        user = context.Users.Where(u => u.UserName == view.ProjectLeaderUserName).Single();
                    }

                    Project project = new Project();
                    if(!user.Id.IsNullOrEmpty())
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

                    return RedirectToAction("AddProjectMembers", "Projects", new { view = nextView }); //detta funkar inte
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
            Project proj = context.Projects.Find(id);
            view.Project = proj;
            return View(view);
        }

        //public IActionResult AddProjectMembers(AddProjectMembersViewModel view) //detta funkar inte
        //{
        //    return View(view);
        //}

        //public async Task<IActionResult> AddProjectMembers(AddProjectMembersViewModel view)
        //{
        //    return View(view);
        //}


        //public IActionResult CreateProject(CreateProjectViewModel view)
        //{


        //    return View(view);
        //}

        //public IActionResult CreateProject(CreateProjectViewModel viewModel)
        //{
        //    return View(viewModel);
        //}


        //[HttpPost]
        //public IActionResult AddCollaborator(CreateProjectViewModel viewModel)
        //{
        //    try
        //    {
        //        User user = context.Users.Where(u => u.UserName == viewModel.EnteredUserName).Single();

        //        List<string> addedUsers = new List<string>();
        //        addedUsers.Add(viewModel.EnteredUserName);
        //        addedUsers.Add("hej");
        //        foreach(var item in viewModel.Collaborators)
        //        {
        //            addedUsers.Add(item.ToString());
        //        }
        //        viewModel.Collaborators = addedUsers;
        //    }
        //    catch (Exception ex)
        //    {
        //        viewModel.ErrorMessage = "Användare med detta användarnamn hittades inte, försök igen.";
        //    }
        //    return View("CreateProject");
        //}

        //public IActionResult CreateProject(CreateProjectViewModel viewModel)
        //{
        //    try
        //    {
        //        if (viewModel.Sender == null)
        //        {

        //        }
        //        else if (viewModel.Sender.Equals("Add"))
        //        {
        //            viewModel.Collaborators.Add(context.Users.Where(u => u.UserName == viewModel.CollaboratorUserName).Single());
        //        }
        //        else
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                return RedirectToAction("Index");
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        viewModel.ErrorMessage = "Användaren hittades inte.";
        //    }
        //    return View(viewModel);


        //}


    }
}
