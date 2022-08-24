using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BooksController(IBooksService booksService, IWebHostEnvironment hostEnvironment)
        {
            _booksService = booksService;
            _hostEnvironment = hostEnvironment;
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
        public async Task<IActionResult> Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(book.ImageFile.FileName);
                    string extension = Path.GetExtension(book.ImageFile.FileName);
                    string path = Path.Combine(wwwPath + "/Images/bookimg", fileName);
                    using(var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await book.ImageFile.CopyToAsync(fileStream);
                    }
                    int AdminCreate = int.Parse(HttpContext.Session.GetString("AdminId"));
                    book.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    book.AdminAddId = AdminCreate;
                    _booksService.InsertBook(book);
                    return RedirectToAction(nameof(Index));
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
