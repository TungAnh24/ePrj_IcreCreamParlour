using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Recipe
    {
        /*public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
        public string MakingProcess { get; set; }
        public int? AdminCreateId { get; set; }
        public DateTime PublistDate { get; set; }
        public int FlavorId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AdminUpdateId { get; set; }*/

        public int RecipeId { get; set; }
        [Required]
        [Display(Name = "Recipe Name")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Recipe Name length must be between 3 and 100")]
        public string RecipeName { get; set; }
        public string Image { get; set; }
        [Required]
        [Display(Name = "Ingredients")]
        public string Ingredients { get; set; }
        [Required]
        [Display(Name = "MakingProcess")]
        public string MakingProcess { get; set; }
        public int? AdminCreateId { get; set; }
        public DateTime PublistDate { get; set; }
        public int FlavorId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? AdminUpdateId { get; set; }

        public virtual Admin AdminCreate { get; set; }
        public virtual Flavor Flavor { get; set; }

        [DisplayName("Image file")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
