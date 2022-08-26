using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using IcreCreamParlour.Model.Mapper;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RecipeController(IRecipeService recipeService, IWebHostEnvironment hostEnvironment)
        {
            _recipeService = recipeService;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var recipeList = _recipeService.GetAll().ToList();
            return View(recipeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Recipe recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(recipe.ImageFile.FileName);
                    string extension = Path.GetExtension(recipe.ImageFile.FileName);
                    recipe.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwPath + "/Images/recipeimg/", recipe.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await recipe.ImageFile.CopyToAsync(fileStream);
                    }
                    int AdminCreate = int.Parse(HttpContext.Session.GetString("AdminId"));
                    recipe.AdminCreateId = AdminCreate;
                    _recipeService.InsertRecipe(recipe);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(recipe);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var getRecipeByid = _recipeService.FindById(id);
            return View(getRecipeByid);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Recipe recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(recipe.ImageFile.FileName);
                    string extension = Path.GetExtension(recipe.ImageFile.FileName);
                    recipe.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwPath + "/Images/recipeimg/", recipe.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await recipe.ImageFile.CopyToAsync(fileStream);
                    }
                    int AdminUpdateId = int.Parse(HttpContext.Session.GetString("AdminId"));
                    recipe.AdminUpdateId = AdminUpdateId;
                    _recipeService.UpdateRecipe(recipe);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(recipe);
        }
        public IActionResult Delete(int id)
        {
            _recipeService.DeleteRecipe(id);
            return RedirectToAction("Index");
        }
    }
}
