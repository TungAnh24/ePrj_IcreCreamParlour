using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class BooksService : IBooksService
    {
        private readonly IGenericRepository<Book> _repository;
        private readonly DbIcecreamParlourContext _context;

        public BooksService(IGenericRepository<Book> repository, DbIcecreamParlourContext context)
        {
            _repository = repository;
            _context = context;
        }

        public Book FinBookById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _repository.GetAll().Where(book => book.IsDelete == 1);
        }

        public void InsertBook(Book book)
        {
            DateTime dateCreate = DateTime.Now;
            book.CreateDate = dateCreate;
            book.IsActive = 1;
            book.IsDelete = 1;
            _repository.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            DateTime updateDate = DateTime.Now;
            book.UpdateDate = updateDate;
            book.IsActive = 1;
            book.IsDelete = 1;
            _repository.Update(book);
        }
        public void DeleteBook(int id)
        {
            var book = _repository.FindById(id);
            book.IsDelete = 0;
            if (book != null)
            {
                _repository.Update(book);
            }
        }

        public IEnumerable<Book> FindByTitle(string strSearch)
        {
            var book = _context.Books.Where(book => book.Title.Contains(strSearch) || strSearch == null).ToList();
            return book;
        }

        public static implicit operator BooksService(GenericRepository<Book> book)
        {
            throw new NotImplementedException();
        }
    }
}
