using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string FlavorName { get; set; }
        public string Ingredients { get; set; }
        public string MakingProcess { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        [DisplayName("File name")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
