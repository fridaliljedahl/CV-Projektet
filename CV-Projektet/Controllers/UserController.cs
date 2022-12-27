﻿using CV_Projektet.Data;
using CV_Projektet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;

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

        public ActionResult JoinProject(int projectId)
        { 
            User_Projects up = new User_Projects();
            up.ProjectID = projectId;
            up.UserID = userManager.GetUserId(User);
            context.User_Projects.Add(up);
            context.SaveChanges();
            return RedirectToAction("Index", "Home"); 
        }
        public ActionResult LeaveProject()
        { 
            return View(); 
        }
    }
}
