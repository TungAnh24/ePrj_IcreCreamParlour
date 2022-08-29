using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Book
    {
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        /*public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public int AdminAddId { get; set; }
        public string Author { get; set; }
        public int? AdminUpdateId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? UpdateDate { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }*/
        public int BookId { get; set; }
        [Required]
        [Display(Name = "Book's Title")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Book's title length must be between 3 and 100")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        public double Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        [Required]
        public int AdminAddId { get; set; }
        [Required]
        [Display(Name = "Author")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Author length must be between 3 and 150")]
        public string Author { get; set; }
        public int? AdminUpdateId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? UpdateDate { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [DisplayName("File name")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
