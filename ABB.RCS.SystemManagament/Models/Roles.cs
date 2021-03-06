﻿using System;
using System.Collections.Generic;

namespace ABB.RCS.SystemManagament.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
