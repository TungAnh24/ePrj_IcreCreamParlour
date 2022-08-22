using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Model.IcreCreamParlour.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Mapper
{
    public static class AutoMapper
    {
        public static RecipeDTO Convert(this Recipe recipe)
        {
            return new RecipeDTO()
            {
                RecipeId = recipe.RecipeId,
                RecipeName = recipe.RecipeName,
                Image = recipe.Image,
                Ingredients = recipe.Ingredients,
                MakingProcess = recipe.MakingProcess,
                AdminCreateId = recipe.AdminCreateId,
                PublistDate = recipe.PublistDate,
                FlavorId = recipe.FlavorId,
                UpdateDate = recipe.UpdateDate,
                AdminUpdateId = recipe.AdminUpdateId,
                AdminCreate = recipe.AdminCreate,
            };
        }
        public static AdminDTO Convert(this Admin admin)
        {
            return new AdminDTO()
            {
                AdminId = admin.AdminId,
                Name = admin.Name,
                Email = admin.Email,
                Roles = admin.Roles,
                Password = admin.Password,
                IsActive = admin.IsActive,
                IsDelete = admin.IsDelete,
            };
        }
    }
}
