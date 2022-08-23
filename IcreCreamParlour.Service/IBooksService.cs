using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcreCreamParlour.Model.DTO;

namespace IcreCreamParlour.Service
{
    public interface IBooksService
    {
        IEnumerable<BookDTO> GetAll();
        Book FinBookById(int id);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        IEnumerable<Book> FindByTitle(string strSearch);
    }
}
