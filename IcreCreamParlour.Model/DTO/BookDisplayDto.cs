using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class BookDisplayDto
    {
        public int BookId { get; set; }
        [DisplayName("Book Title")]
        public string Title { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreateDate { get; set; }

        public long? AdminAddId { get; set; }

        [DisplayName("Created by")]
        public string CreatedAdmin { get; set; }

        public string Author { get; set; }
        [DisplayName("Updated by")]
        public long? AdminUpdateId { get; set; }

        [DisplayName("Last updated by")]
        public string UpdatedAdmin { get; set; }
        
        [DisplayName("Last updated date")]
        public DateTime? UpdateDate { get; set; }

        public int? IsActive { get; set; }

        public int? IsDelete { get; set; }
    }
}
