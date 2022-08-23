using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int AdminAddId { get; set; }
        public string Author { get; set; }
        public int? AdminUpdateId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }
        public string PersonCreate { get; set; }
        public string PersonUpdate { get; set; }

        /*public BookDTO(int bookId, string title, string description, string image, double price, DateTime createDate, int adminAddId, string author, int? adminUpdateId, DateTime? updateDate, int? isActive, int? isDelete, string personCreate, string personUpdate)
        {
            BookId = bookId;
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            CreateDate = createDate;
            AdminAddId = adminAddId;
            Author = author;
            AdminUpdateId = adminUpdateId;
            UpdateDate = updateDate;
            IsActive = isActive;
            IsDelete = isDelete;
            PersonCreate = personCreate;
            PersonUpdate = personUpdate;
        }

        public BookDTO()
        {
        }*/
    }
}
