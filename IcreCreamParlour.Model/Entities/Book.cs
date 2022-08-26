﻿using Microsoft.AspNetCore.Http;
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

        public int BookId { get; set; }
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
        public int? IsDelete { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [DisplayName("File name")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
