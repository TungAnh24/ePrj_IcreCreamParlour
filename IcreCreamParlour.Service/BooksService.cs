using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcreCreamParlour.Model;
using IcreCreamParlour.Model.DTO;

namespace IcreCreamParlour.Service
{
    public class BooksService : IBooksService
    {
        private readonly IGenericRepository<Book> _repositoryBook;
        private readonly IGenericRepository<Admin> _repositoryAdmin;
        private readonly DbIcecreamParlourContext _context;

        public BooksService(IGenericRepository<Book> repositoryBook, IGenericRepository<Admin> repositoryAdmin, DbIcecreamParlourContext context)
        {
            _repositoryBook = repositoryBook;
            _repositoryAdmin = repositoryAdmin;
            _context = context;
        }

        public Book FinBookById(int id)
        {
            return _repositoryBook.FindById(id);
        }

        public IEnumerable<BookDTO> GetAll()
        {
            return _repositoryBook.GetAll().ToList().Select(book =>
            {
                var bookDTO = book.Convert();
                bookDTO.PersonCreate = _repositoryAdmin.FindById(book.AdminAddId).Name;
                if (bookDTO.AdminUpdateId != null)
                {
                    bookDTO.PersonUpdate = _repositoryAdmin.FindById(book.AdminUpdateId.Value).Name;
                }
                return bookDTO;
            });
        }

        public void InsertBook(Book book)
        {
            DateTime dateCreate = DateTime.Now;
            book.CreateDate = dateCreate;
            book.IsActive = 1;
            book.IsDelete = 1;
            _repositoryBook.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            DateTime updateDate = DateTime.Now;
            book.UpdateDate = updateDate;
            book.IsActive = 1;
            book.IsDelete = 1;
            _repositoryBook.Update(book);
        }
        public void DeleteBook(int id)
        {
            var book = _repositoryBook.FindById(id);
            book.IsDelete = 0;
            if (book != null)
            {
                _repositoryBook.Update(book);
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
