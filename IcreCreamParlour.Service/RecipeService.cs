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
        private readonly IGenericRepository<RecipeService> _repository;

        public RecipeService(IGenericRepository<RecipeService> repository)
        {
            _repository = repository;
        }

        public void DeleteRecipe(int id)
        {
            _repository.Delete(id);
        }

        public RecipeService FindById(int id)
        {
            return _repository.FindById(id);        }

        public IEnumerable<RecipeService> GetAll()
        {
            return _repository.GetAll();        }

        public void InsertRecipe(RecipeService recipe)
        {
            _repository.Insert(recipe);
        }

        public void UpdateRecipe(RecipeService recipe)
        {
            _repository.Update(recipe);
        }
        public static implicit operator RecipeService(GenericRepository<RecipeService> recipe)
        {
            throw new NotImplementedException();
        }
    }
}
