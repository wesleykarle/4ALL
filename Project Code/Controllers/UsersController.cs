using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _4ALLApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public ActionResult AddOrEdit(User user, LoginDbContext loginDbContext)
        {
            using (loginDbContext)
            {
                if (user.UserName.Any(x => user.UserName == user.UserName))
                {
                    ViewBag.DuplicateMessage = "User Name Already Exists.";
                    return View("SignUp", user);
                }
                else
                {

                }
            }
            ModelState.Clear();
            @ViewBag.SuccessMessage = "Registration Successful.";
            return View("SignUp", new User());
        }
    }
}