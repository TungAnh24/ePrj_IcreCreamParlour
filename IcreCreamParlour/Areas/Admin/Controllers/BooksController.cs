using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

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

        public IActionResult Index( int? page, string strSearching = "")
        {
            var books = _booksService.GetAll().ToList();
            if (strSearching != "" && strSearching != null)
            {
                books = books.Where(book => book.Title.Contains((strSearching))).ToPagedList(page ?? 1, 5).ToList();
                ViewBag.test = books;
            }
            return View(books);
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
                    book.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwPath + "/Images/bookimg/", book.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await book.ImageFile.CopyToAsync(fileStream);
                    }
                    int AdminCreate = int.Parse(HttpContext.Session.GetString("AdminId"));
                    book.AdminAddId = AdminCreate;
                    if (_booksService.GetAll().Any(b => b.Title == book.Title && b.Author == book.Author))
                    {

                        ViewBag.InsertBook = "1";
                    }
                    else
                    {
                        _booksService.InsertBook(book);
                        return RedirectToAction(nameof(Index));
                    }

                    /*return RedirectToAction(nameof(Index));*/

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
        public async Task<IActionResult> Edit(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string wwwPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(book.ImageFile.FileName);
                    string extension = Path.GetExtension(book.ImageFile.FileName);
                    book.Image = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwPath + "/Images/bookimg/", book.Image);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await book.ImageFile.CopyToAsync(fileStream);
                    }
                    int AdminUpdateId = int.Parse(HttpContext.Session.GetString("AdminId"));
                    book.AdminUpdateId = AdminUpdateId;
                    if (book.Image == null)
                    {
                        book.Image = book.Image;
                    }
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
