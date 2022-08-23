using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public IActionResult Index()
        {
            return View(_booksService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int AdminCreate = int.Parse(HttpContext.Session.GetString("AdminId"));
                    book.AdminAddId = AdminCreate;
                    _booksService.InsertBook(book);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(book);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_booksService.FinBookById(id));
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int AdminUpdateId = int.Parse(HttpContext.Session.GetString("AdminId"));
                    book.AdminUpdateId = AdminUpdateId;
                    _booksService.UpdateBook(book);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(book);
        }
        public IActionResult Delete(int id)
        {
            _booksService.DeleteBook(id);
            return RedirectToAction("Index");
        }
    }
}
