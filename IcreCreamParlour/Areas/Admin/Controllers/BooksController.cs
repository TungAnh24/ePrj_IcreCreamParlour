﻿using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View(_booksService.GetAll().ToList());
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
                    DateTime dateCreate = DateTime.Now;
                    book.CreateDate = dateCreate;
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
                    DateTime dateCreate = DateTime.Now;
                    book.CreateDate = dateCreate;
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
