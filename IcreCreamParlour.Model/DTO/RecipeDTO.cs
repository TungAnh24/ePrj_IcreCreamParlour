using IcreCreamParlour.Model.Entities;
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

        public RecipeDTO(int recipeId, string recipeName, string image, string ingredients, string makingProcess, int? adminCreateId, DateTime publistDate, int flavorId, DateTime? updateDate, int? adminUpdateId, string flavorName, string perSonNameCreate, string perSonNameUpdate, List<Recipe> recipes)
        {
            RecipeId = recipeId;
            RecipeName = recipeName;
            Image = image;
            Ingredients = ingredients;
            MakingProcess = makingProcess;
            AdminCreateId = adminCreateId;
            PublistDate = publistDate;
            FlavorId = flavorId;
            UpdateDate = updateDate;
            AdminUpdateId = adminUpdateId;
            FlavorName = flavorName;
            PerSonNameCreate = perSonNameCreate;
            PerSonNameUpdate = perSonNameUpdate;
            Recipes = recipes;
        }

        public RecipeDTO()
        {
        }
    }
}
