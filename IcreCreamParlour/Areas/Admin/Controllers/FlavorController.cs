using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlavorController : Controller
    {
        private readonly IFlavorService _flavorService;

        public FlavorController(IFlavorService flavorService)
        {
            _flavorService = flavorService;
        }

        public IActionResult Index()
        {
            var flavor = _flavorService.GetAll().ToList();
            return View(flavor);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Flavor flavor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _flavorService.InsertFlavor(flavor);
                    RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(flavor);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var getFlavorById = _flavorService.FindById(id);
            return View(getFlavorById);
        }
        [HttpPost]
        public IActionResult Edit(Flavor flavor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _flavorService.UpdateFlavor(flavor);
                    RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(flavor);
        }
        public IActionResult Delete(int id)
        {
            _flavorService.DeleteFlavor(id);
            return RedirectToAction("Index");
        }
    }
}
