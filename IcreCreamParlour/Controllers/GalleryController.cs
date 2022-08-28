using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;

namespace IcreCreamParlour.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IBooksService _booksService;
        private readonly IRecipeService _recipeService;
        private readonly IFlavorService _flavorService;

        public GalleryController(IBooksService booksService, IRecipeService recipeService, IFlavorService flavorService)
        {
            _booksService = booksService;
            _recipeService = recipeService;
            _flavorService = flavorService;
        }

        public IActionResult Index()
        {
            ViewData["books"] = _booksService.GetAll();
            ViewData["recipes"] = _recipeService.GetAll();
            ViewData["flavors"] = _flavorService.GetAll();
            return View();
        }
    }
}
