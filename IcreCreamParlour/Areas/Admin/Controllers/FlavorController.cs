using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlavorController : Controller
    {
        private readonly IFlavorService _flavorService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public FlavorController(IFlavorService flavorService, IWebHostEnvironment hostEnvironment)
        {
            _flavorService = flavorService;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var flavor = _flavorService.GetAll();
            return View(flavor);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Flavor flavor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(flavor.ImageFile.FileName);
                    string extension = Path.GetExtension(flavor.ImageFile.FileName);
                    flavor.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwPath + "/Images/flavorimg/", flavor.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await flavor.ImageFile.CopyToAsync(fileStream);
                    }
                    _flavorService.InsertFlavor(flavor);
                    return RedirectToAction("Index");
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
        public async Task<IActionResult> Edit(Flavor flavor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(flavor.ImageFile.FileName);
                    string extension = Path.GetExtension(flavor.ImageFile.FileName);
                    flavor.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwPath + "/Images/flavorimg/", flavor.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await flavor.ImageFile.CopyToAsync(fileStream);
                    }
                    _flavorService.UpdateFlavor(flavor);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(ModelState);
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
