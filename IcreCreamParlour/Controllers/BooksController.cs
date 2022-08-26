using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IBooksService _booksService;
        private readonly IRecipeService _recipeService;
        private readonly IFlavorService _flavorService;

        public BooksController(IAdminService adminService, IBooksService booksService, IRecipeService recipeService, IFlavorService flavorService)
        {
            _adminService = adminService;
            _booksService = booksService;
            _recipeService = recipeService;
            _flavorService = flavorService;
        }

        public IActionResult Index()
        {
            /*if (HttpContext.Session.GetString("AdminId") == null)
            {
                return Redirect("Home/Login");
            }*/
            var bookClientView = _booksService.GetAll().ToList();
            return View(bookClientView);
        }
    }
}
