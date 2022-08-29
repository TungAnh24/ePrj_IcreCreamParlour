using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Admin
    {
        public Admin()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int AdminId { get; set; }
        [Required]
        [Display(Name ="Admin's Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Admin's Name length must be between 3 and 50")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
        [Required]
        public int? Roles { get; set; }
        [Required]
        public string Password { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
