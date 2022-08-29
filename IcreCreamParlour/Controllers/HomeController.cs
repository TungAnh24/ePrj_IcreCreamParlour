using IcreCreamParlour.Models;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminService _adminService;
        private readonly IBooksService _booksService;
        private readonly IRecipeService _recipeService;
        private readonly IFlavorService _flavorService;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IAdminService adminService, IBooksService booksService, IRecipeService recipeService, IFlavorService flavorService, IUserService userService)
        {
            _logger = logger;
            _adminService = adminService;
            _booksService = booksService;
            _recipeService = recipeService;
            _flavorService = flavorService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            ViewData["books"] = _booksService.GetAll();
            ViewData["recipes"] = _recipeService.GetAll();
            ViewData["accounts"] = _adminService.GetAll();
            ViewData["users"] = _userService.GetAll();
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var account = _userService.GetAll().ToList().SingleOrDefault(account => account.Email.Equals(username) && account.Password.Equals(password));
            if (account != null)
            {
                ViewBag.message1 = "1";
                return Redirect("/Home");
            }
            return RedirectToAction("Login");
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
