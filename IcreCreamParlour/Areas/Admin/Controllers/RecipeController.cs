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
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            return View();
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
                    DateTime publishDate = DateTime.Now;
                    recipe.PublistDate = publishDate;
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
                    DateTime publishDate = DateTime.Now;
                    recipe.PublistDate = publishDate;
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
