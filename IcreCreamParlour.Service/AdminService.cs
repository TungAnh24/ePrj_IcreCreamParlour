using IcreCreamParlour.Model.Entities;
using IcreCreamParlour.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Service
{
    public class AdminService : IAdminService
    {
        private readonly IGenericRepository<Admin> _repository;
        public void DeleteAdmin(int id)
        {
            _repository.Delete(id);
        }

        public Admin FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return _repository.GetAll();
        }

        public void InsertAdmin(Admin admin)
        {
            _repository.Insert(admin);
        }

        public void UpdateAdmin(Admin admin)
        {
            _repository.Update(admin);
        }
        public static implicit operator AdminService(GenericRepository<Admin> admin)
        {
            throw new NotImplementedException();
        }
    }
}
