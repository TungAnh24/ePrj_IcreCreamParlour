using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
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
