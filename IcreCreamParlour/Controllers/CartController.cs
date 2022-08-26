using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Controllers
{
    public class CartController : Controller
    {
        private readonly IBooksService _booksService;

        public CartController(IBooksService booksService)
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
