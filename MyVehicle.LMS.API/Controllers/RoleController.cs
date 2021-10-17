using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        [HttpDelete ("delete")]
        public bool DeleteRole([FromBody] Role role)
        {
            return roleService.DeleteRole(role);
        }
        [HttpGet]
        [Route("GetAllRole")]
        public List<Role> GetAllRole()
        {
            return roleService.GetAllRole();
        }
        [HttpGet]
        [Route("GetRoleById")]
        public Role GetRoleById(Role role)
        {
            return roleService.GetRoleById(role);
        }
        [HttpPost]
        public bool InsertRole([FromBody] Role role)
        {
            return roleService.InsertRole(role);
        }
        [HttpPut]
        public bool UpdateRole([FromBody] Role role)
        {
            return roleService.UpdateRole(role);
        }
    }
}
