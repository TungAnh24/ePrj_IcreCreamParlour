using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " Name length must be between 3 and 50")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Contact")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Contact length must be between 3 and 150")]
        public string Contact { get; set; }
        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Address")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Address length must be between 3 and 100")]
        public string Address { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 9, ErrorMessage = "Address length must be between 9 and 15")]
        public string CardNo { get; set; }
        public double TotalAmount { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
