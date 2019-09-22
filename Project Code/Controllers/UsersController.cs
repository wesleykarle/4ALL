using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4ALLweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4ALLweb.Controllers
{
    public class UsersController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> Users(UserData model)
        {
            if (ModelState.IsValid)
            {
                var users = new UserData
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.UserName,
                    Password = model.Password,
                    City = model.City,
                    State = model.State,
                    Zip = model.Zip,
                    PhoneNumber = model.PhoneNumber
                };

            }
            return View();
        }
    }
}