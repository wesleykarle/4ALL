using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _4ALLweb.Models;

namespace _4ALLweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public object Login_Data { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult HomeView()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactPage()
        {
            return View();
        }
        public IActionResult ProfileView()
        {
            return View();
        }
        public IActionResult Mailbox()
        {
            return View();
        }

        public IActionResult Badges()
        {
            return View();
        }
        public IActionResult WelcomePage()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
