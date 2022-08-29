using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

#nullable disable

namespace IcreCreamParlour.Model.Entities
{
    public partial class Flavor
    {
        public Flavor()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int FlavorId { get; set; }
        [Required]
        [Display(Name = "Flavor Name")]
        public string FlavorName { get; set; }
        [Required]
        [Display(Name = "Ingredients")]
        public string Ingredients { get; set; }
        [Required]
        [Display(Name = "MakingProcess")]
        public string MakingProcess { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        [DisplayName("File name")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
