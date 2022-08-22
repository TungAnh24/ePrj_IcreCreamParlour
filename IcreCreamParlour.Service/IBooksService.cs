using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAll();
        Book FinBookById(int id);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        IEnumerable<Book> FindByTitle(string strSearch);
    }
}
