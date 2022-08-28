using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;

namespace IcreCreamParlour.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly IFlavorService _flavorService;

        public ServiceController(IRecipeService recipeService, IFlavorService flavorService)
        {
            _recipeService = recipeService;
            _flavorService = flavorService;
        }

        public IActionResult Index()
        {
            ViewData["recipes"] = _recipeService.GetAll();
            ViewData["flavors"] = _flavorService.GetAll();
            return View();
        }
    }
}
