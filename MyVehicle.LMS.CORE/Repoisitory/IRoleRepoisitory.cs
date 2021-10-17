﻿using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
 public   interface IRoleRepoisitory
    {
        public bool InsertRole(Role role);
        public bool UpdateRole(Role role);
        public bool DeleteRole(Role role);
        public List<Role> GetAllRole();
        public Role GetRoleById(Role role);
    }
}
