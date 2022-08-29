using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class User
    {
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
            SubscriptionPayments = new HashSet<SubscriptionPayment>();
        }

        public int UserId { get; set; }
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
        public string Password { get; set; }
        public int UserType { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 9, ErrorMessage = "Address length must be between 9 and 15")]
        public string CardNo { get; set; }
        public DateTime JoinDate { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayments { get; set; }
    }
}
