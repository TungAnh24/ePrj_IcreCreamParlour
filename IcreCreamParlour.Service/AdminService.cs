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
    public class AdminService : IAdminService
    {
        private readonly IGenericRepository<Admin> _repository;

        public AdminService(IGenericRepository<Admin> repository)
        {
            _repository = repository;
        }

        public void DeleteAdmin(int id)
        {
            var getAdminById = _repository.FindById(id);
            getAdminById.IsActive = 0;
            getAdminById.IsDelete = 1;
            _repository.Update(getAdminById);
        }

        public Admin FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<AdminDTO> GetAll()
        {
            return _repository.GetAll().ToList().Where(admin => admin.IsDelete == 1).Select(admin => {
                var adminDTO = admin.Convert();
                adminDTO.RoleName = adminDTO.Roles == 1 ? "SuperAdmin" : "Staff";
                adminDTO.Status = adminDTO.IsActive == 1 ? "Active" : "Inactive";
                return adminDTO;
            });
        }

        public void InsertAdmin(Admin admin)
        {
            admin.Roles = 0;
            admin.IsActive = 1;
            admin.IsDelete = 1;
            _repository.Insert(admin);
        }

        public void UpdateAdmin(Admin admin)
        {
            admin.Roles = 0;
            admin.IsDelete = 1;
            admin.IsDelete = 1;
            _repository.Update(admin);
        }

        public void UnlockAcount(int id)
        {
            var getAdminById = _repository.FindById(id);
            getAdminById.IsActive = 1;
            getAdminById.IsDelete = 1;
            _repository.Update(getAdminById);
        }

        public static implicit operator AdminService(GenericRepository<Admin> admin)
        {
            throw new NotImplementedException();
        }
    }
}
