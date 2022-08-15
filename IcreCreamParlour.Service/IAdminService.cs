using IcreCreamParlour.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public interface IAdminService
    {
        IEnumerable<Admin> GetAll();
        Admin FindById(int id);
        void InsertAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        void DeleteAdmin(int id);
    }
}
