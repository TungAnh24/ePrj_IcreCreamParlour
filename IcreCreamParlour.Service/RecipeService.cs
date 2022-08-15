using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly IGenericRepository<Recipe> _repository;

        public RecipeService(IGenericRepository<Recipe> repository)
        {
            _repository = repository;
        }

        public void DeleteRecipe(int id)
        {
            _repository.Delete(id);
        }

        public Recipe FindById(int id)
        {
            return _repository.FindById(id);        }

        public IEnumerable<Recipe> GetAll()
        {
            return _repository.GetAll();        }

        public void InsertRecipe(Recipe recipe)
        {
            _repository.Insert(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _repository.Update(recipe);
        }
        public static implicit operator RecipeService(GenericRepository<RecipeService> recipe)
        {
            throw new NotImplementedException();
        }
    }
}
