using System;
using System.Collections.Generic;

namespace ABB.RCS.SystemManagament.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public int? RoleId { get; set; }

        public Roles Role { get; set; }
    }
}
