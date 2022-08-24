using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcreCreamParlour.Model.Entities;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAdminService _adminService;

        public AccountController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var admins = _adminService.GetAll();
            return View(admins);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IcreCreamParlour.Model.Entities.Admin admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _adminService.InsertAdmin(admin);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(admin);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var getAdminById = _adminService.FindById(id);
            return View(getAdminById);
        }
        [HttpPost]
        public IActionResult Edit(IcreCreamParlour.Model.Entities.Admin admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _adminService.InsertAdmin(admin);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(admin);
        }
        public IActionResult Delete(int id)
        {
            _adminService.DeleteAdmin(id);
            return RedirectToAction("Index");
        }
    }
}
