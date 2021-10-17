using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public  class RoleService: IRoleService
    {
        private readonly IRoleRepoisitory roleRepoisitory;
        public RoleService(IRoleRepoisitory roleRepoisitory)
        {
            this.roleRepoisitory = roleRepoisitory;
        }

        public bool DeleteRole(Role role)
        {
            return roleRepoisitory.DeleteRole(role);
        }

        public List<Role> GetAllRole()
        {
            return roleRepoisitory.GetAllRole();
        }

        public Role GetRoleById(Role role)
        {
            return roleRepoisitory.GetRoleById(role);
        }

        public bool InsertRole(Role role)
        {
            return roleRepoisitory.InsertRole(role);
        }

        public bool UpdateRole(Role role)
        {
            return roleRepoisitory.UpdateRole(role);
        }
    }
}
