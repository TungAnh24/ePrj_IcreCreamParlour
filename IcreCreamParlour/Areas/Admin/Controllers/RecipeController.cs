using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using IcreCreamParlour.Model.Mapper;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly IAdminService _adminService;
        private readonly IFlavorService _flavorService;

        public RecipeController(IRecipeService recipeService, IAdminService adminService, IFlavorService flavorService)
        {
            _recipeService = recipeService;
            _adminService = adminService;
            _flavorService = flavorService;
        }

        public IActionResult Index()
        {
            var recipeList = _recipeService.GetAll().ToList().Select(recipe =>
            {
                var recipeDTO = recipe.Convert();
                if (recipeDTO.AdminCreateId != null)
                {

                    recipeDTO.PerSonNameCreate = _adminService.FindById(recipeDTO.AdminCreateId.Value).Name;
                }
                if (recipeDTO.AdminUpdateId != null)
                {
                    recipeDTO.PerSonNameUpdate = _adminService.FindById(recipeDTO.AdminUpdateId.Value).Name;
                }
                recipeDTO.FlavorName = _flavorService.FindById(recipeDTO.FlavorId)?.FlavorName;
                return recipeDTO;
            });
            return View(recipeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Recipe recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
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
        public IActionResult Edit(Recipe recipe)
        {
            try
            {
                if (ModelState.IsValid)
                {
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
