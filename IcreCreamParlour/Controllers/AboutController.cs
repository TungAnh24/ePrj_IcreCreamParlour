using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;

namespace IcreCreamParlour.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAdminService _adminService;

        public AboutController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var adminClient = _adminService.GetAll();
            ViewData["admins"] = adminClient;
            return View();
        }
    }
}
