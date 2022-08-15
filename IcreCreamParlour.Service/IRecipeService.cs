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
        IEnumerable<RecipeService> GetAll();
        RecipeService FindById(int id);
        void InsertRecipe(RecipeService recipe);
        void UpdateRecipe(RecipeService recipe);
        void DeleteRecipe(int id);
    }
}
