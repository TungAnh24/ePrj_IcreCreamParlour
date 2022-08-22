using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcreCreamParlour.Model.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string CardNo { get; set; }
        public DateTime JoinDate { get; set; }
        public int IsActive { get; set; }
        public int IsDelete { get; set; }

        public UserDTO(int userId, string name, string contact, string email, string address, string password, int userType, string cardNo, DateTime joinDate, int isActive, int isDelete)
        {
            UserId = userId;
            Name = name;
            Contact = contact;
            Email = email;
            Address = address;
            Password = password;
            UserType = userType;
            CardNo = cardNo;
            JoinDate = joinDate;
            IsActive = isActive;
            IsDelete = isDelete;
        }

        public UserDTO()
        {
        }
    }
}
