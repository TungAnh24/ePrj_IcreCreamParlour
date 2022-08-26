using IcreCreamParlour.Model.DTO;
using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IRecipeService
    {
        IEnumerable<RecipeDTO> GetAll();
        Recipe FindById(int id);
        void InsertRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
    }
}
