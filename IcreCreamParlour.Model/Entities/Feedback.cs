using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        [Required]
        [Display(Name ="Feedback Detail")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Feedback detail length must be between 3 and 150")]
        public string FeedbackDetail { get; set; }
        public int? UserId { get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name length must be between 3 and 50")]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Contact")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Contact length must be between 3 and 150")]
        public string Contact { get; set; }
        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        public virtual User User { get; set; }
    }
}
