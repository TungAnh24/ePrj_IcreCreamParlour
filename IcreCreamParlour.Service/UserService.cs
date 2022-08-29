using IcreCreamParlour.Model.DTO;
using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Model.Mapper;
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
        private readonly IGenericRepository<User> _repository;

        public UserService(IGenericRepository<User> repository)
        {
            _repository = repository;
        }

        public void DeleteUser(int id)
        {
            _repository.Delete(id);
        }

        public User FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var users = _repository.GetAll().Where(user => user.IsActive == 1 && user.IsDelete == 1).ToList().Select(user => user.Convert());
            return users;
        }

        public void InsertUser(User user)
        {
            DateTime joinDate = DateTime.Now;
            user.JoinDate = joinDate;
            _repository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _repository.Update(user);
        }
        public static implicit operator UserService(GenericRepository<User> user)
        {
            throw new NotImplementedException();
        }
    }
}
