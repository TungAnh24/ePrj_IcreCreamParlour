using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;

namespace IcreCreamParlour.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBooksService _booksService;

        public ProductController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public IActionResult Index()
        {
            ViewData["books"] = _booksService.GetAll();
            return View();
        }
    }
}
