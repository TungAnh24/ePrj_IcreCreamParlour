using IcreCreamParlour.Model.DTO;
using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Model.ObjResponse;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class ResponseService : IResponseService
    {
        private readonly IGenericRepository<HomeResponse> _repositoryHomeResponse;
        private readonly IGenericRepository<Book> _repositoryBook;
        private readonly IGenericRepository<Recipe> _repositoryRecipe;
        private readonly IGenericRepository<Admin> _repositoryAdmin;

        public ResponseService(IGenericRepository<HomeResponse> repositoryHomeResponse, IGenericRepository<Book> repositoryBook, IGenericRepository<Recipe> repositoryRecipe, IGenericRepository<Admin> repositoryAdmin)
        {
            _repositoryHomeResponse = repositoryHomeResponse;
            _repositoryBook = repositoryBook;
            _repositoryRecipe = repositoryRecipe;
            _repositoryAdmin = repositoryAdmin;
        }

        public IEnumerable<HomeResponse> GetAll()
        {
            var dataHomeResponse = _repositoryHomeResponse.GetAll().Select(obj => 
            {
                obj.BookResponse = _repositoryBook.GetAll();
                obj.RecipeResponse = _repositoryRecipe.GetAll();
                obj.AdminResponse = _repositoryAdmin.GetAll();
                return obj;
            });
            return dataHomeResponse;
        }
    }
}
