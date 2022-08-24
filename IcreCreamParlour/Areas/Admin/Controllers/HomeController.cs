using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcreCreamParlour.Model.Entities;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IAdminService _adminService;

        public HomeController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            var account = _adminService.GetAll().Where(account => account.IsDelete == 1 && account.IsActive == 1).ToList().SingleOrDefault(account => account.Name.Equals(userName) && account.Password.Equals(password));
            if (account != null)
            {
                HttpContext.Session.SetString("AdminId", account.AdminId.ToString());
                ViewBag.message1 = "1";
                return Redirect("/Admin/Home/Index");
            }
            return RedirectToAction("Login");
        }
    }
}
