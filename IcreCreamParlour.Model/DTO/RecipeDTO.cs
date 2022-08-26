using IcreCreamParlour.Model.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class RecipeDTO
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
        public string FlavorName { get; set; }
        public string PerSonNameCreate { get; set; }
        public string PerSonNameUpdate { get; set; }
        public List<Recipe> Recipes { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
