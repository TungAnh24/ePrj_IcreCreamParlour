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
        public string RoleName { get; set; }
        public string Status { get; set; }
        /*public string Status { get { return Status = IsActive == 1 ? "Active" : "Inactive"; } set { Status = value; } }*/

    }
}
