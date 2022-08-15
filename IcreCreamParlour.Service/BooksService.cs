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

        public BooksService(IGenericRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book FinBookById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertBook(Book book)
        {
            _repository.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.Update(book);
        }
        public void DeleteBook(int id)
        {
            _repository.Delete(id);
        }
        public static implicit operator BooksService(GenericRepository<Book> book)
        {
            throw new NotImplementedException();
        }
    }
}
