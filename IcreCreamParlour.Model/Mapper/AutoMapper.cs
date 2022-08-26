using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.Mapper
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
                ImageFile = recipe.ImageFile
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
        public static BookDTO Convert(this Book book)
        {
            return new BookDTO()
            {
                BookId = book.BookId,
                Title = book.Title,
                Description = book.Description,
                Image = book.Image,
                Price = book.Price,
                CreateDate = book.CreateDate,
                AdminAddId = book.AdminAddId,
                Author = book.Author,
                AdminUpdateId = book.AdminUpdateId,
                UpdateDate = book.UpdateDate,
                IsActive = book.IsActive,
                IsDelete = book.IsDelete,
                ImageFile = book.ImageFile
            };
        }
        public static FeedbackDTO Convert(this Feedback feedback)
        {
            return new FeedbackDTO
            {
                FeedbackId = feedback.FeedbackId,
                FeedbackDetail = feedback.FeedbackDetail,
                UserId = feedback.UserId,
                Name = feedback.Name,
                Date = feedback.Date,
                Contact = feedback.Contact,
                Email = feedback.Email
            };
        }
        public static UserDTO Convert(this User user)
        {
            return new UserDTO
            {
                UserId = user.UserId,
                Name = user.Name,
                Contact = user.Contact,
                Email = user.Email,
                Address = user.Address,
                Password = user.Password,
                UserType = user.UserType,
                CardNo = user.CardNo,
                JoinDate = user.JoinDate,
                IsActive = user.IsActive,
                IsDelete = user.IsDelete
            };
        }
        public static FlavorDTO Convert(this Flavor flavor)
        {
            return new FlavorDTO()
            {
                FlavorId = flavor.FlavorId,
                FlavorName = flavor.FlavorName,
                Ingredients = flavor.Ingredients,
                MakingProcess = flavor.MakingProcess,
                Description = flavor.Description,
                Image = flavor.Image,
                ImageFile = flavor.ImageFile
            };
        }
    }
}
