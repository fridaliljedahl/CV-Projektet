using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CV_Projektet.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private ApplicationDbContext context;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        public ActionResult JoinProject(int projectId, string caller)
        {
            User_Projects up = new User_Projects();
            up.ProjectID = projectId;
            up.UserID = userManager.GetUserId(User);
            context.User_Projects.Add(up);
            context.SaveChanges();
            if (caller.Equals("Home"))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Projects");
            }

        }
        public ActionResult LeaveProject(int projectId, string caller)
        {
            var up = context.User_Projects.Where
                (p => p.ProjectID == projectId && p.UserID == userManager.GetUserId(User)).Single();
            context.User_Projects.Remove(up);
            context.SaveChanges();
            if (caller.Equals("Home"))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Projects");
            }
        }
    }
}
