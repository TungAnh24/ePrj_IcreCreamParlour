using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _userServiced;

        public UserController(IUserService userServiced)
        {
            _userServiced = userServiced;
        }

        public IActionResult Index()
        {
            var users = _userServiced.GetAll();
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userServiced.InsertUser(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var getUserById = _userServiced.FindById(id);
            return View(getUserById);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DateTime joinDate = DateTime.Now;
                    user.JoinDate = joinDate;
                    _userServiced.UpdateUser(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }
        public IActionResult Delete(int id)
        {
            _userServiced.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
