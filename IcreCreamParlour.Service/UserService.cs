using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<UserService> _repository;

        public UserService(IGenericRepository<UserService> repository)
        {
            _repository = repository;
        }

        public void DeleteUser(int id)
        {
            _repository.Delete(id);        }

        public UserService FindById(int id)
        {
            return _repository.FindById(id);        }

        public IEnumerable<UserService> GetAll()
        {
            return _repository.GetAll();       }

        public void InsertUser(UserService user)
        {
            _repository.Insert(user);
        }

        public void UpdateUser(UserService user)
        {
            _repository.Update(user);
        }
        public static implicit operator UserService(GenericRepository<UserService> user)
        {
            throw new NotImplementedException();
        }
    }
}
