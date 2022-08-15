using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IUserService
    {
        IEnumerable<UserService> GetAll();
        UserService FindById(int id);
        void InsertUser(UserService user);
        void UpdateUser(UserService user);
        void DeleteUser(int id);
    }
}
