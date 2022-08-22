using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Roles { get; set; }
        public string Password { get; set; }
        public int? IsActive { get; set; }
        public int? IsDelete { get; set; }

        public AdminDTO(int adminId, string name, string email, int? roles, string password, int? isActive, int? isDelete)
        {
            AdminId = adminId;
            Name = name;
            Email = email;
            Roles = roles;
            Password = password;
            IsActive = isActive;
            IsDelete = isDelete;
        }

        public AdminDTO()
        {
        }
    }
}
