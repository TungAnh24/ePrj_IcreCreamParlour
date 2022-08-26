using IcreCreamParlour.Model.DTO;
using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Model.Mapper;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IcreCreamParlour.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly IGenericRepository<Recipe> _repoRecipe;
        private readonly IGenericRepository<Admin> _repoAdmin;
        private readonly IGenericRepository<Flavor> _repoFlavor;

        public RecipeService(IGenericRepository<Recipe> repoRecipe, IGenericRepository<Admin> repoAdmin, IGenericRepository<Flavor> repoFlavor)
        {
            _repoRecipe = repoRecipe;
            _repoAdmin = repoAdmin;
            _repoFlavor = repoFlavor;
        }

        public void DeleteRecipe(int id)
        {
            _repoRecipe.Delete(id);
        }

        public Recipe FindById(int id)
        {
            return _repoRecipe.FindById(id);
        }

        public IEnumerable<RecipeDTO> GetAll()
        {
            var recipeList = _repoRecipe.GetAll().ToList().Select(recipe =>
            {
                var recipeDTO = recipe.Convert();
                if (recipeDTO.AdminCreateId != null)
                {

                    recipeDTO.PerSonNameCreate = _repoAdmin.FindById(recipeDTO.AdminCreateId.Value).Name;
                }
                if (recipeDTO.AdminUpdateId != null)
                {
                    recipeDTO.PerSonNameUpdate = _repoAdmin.FindById(recipeDTO.AdminUpdateId.Value).Name;
                }
                recipeDTO.FlavorName = _repoFlavor.FindById(recipeDTO.FlavorId)?.FlavorName;
                return recipeDTO;
            });
            return recipeList;
        }

        public void InsertRecipe(Recipe recipe)
        {
            DateTime publishDate = DateTime.Now;
            recipe.PublistDate = publishDate;
            _repoRecipe.Insert(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            DateTime updateDate = DateTime.Now;
            recipe.UpdateDate = updateDate;
            /*recipe.Flavor = _repoFlavor.GetAll().ToList();*/
            _repoRecipe.Update(recipe);
        }

        public static implicit operator RecipeService(GenericRepository<RecipeService> recipe)
        {
            throw new NotImplementedException();
        }
    }
}
