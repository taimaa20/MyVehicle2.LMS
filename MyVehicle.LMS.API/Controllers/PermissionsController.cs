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
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionsService permissionsService;
        public PermissionsController(IPermissionsService permissionsService)
        {
            this.permissionsService = permissionsService;
        }
        [HttpPost]
        [Route("InsertPermissions")]
        public bool InsertPermissions(int RoleId)
        {
            return permissionsService.InsertPermissions(RoleId);
        }
        [HttpPut]
        [Route("UpdatePermissions")]
        public bool UpdatePermissions(Permissions Per)
        {
            return permissionsService.UpdatePermissions(Per);
        }

        [HttpDelete]
        [Route("DeletePermissions")]
        public bool DeletePermissions(int PermissionsId)
        {
            return permissionsService.DeletePermissions(PermissionsId);
        }

        [HttpGet]
        [Route("GetAllPermissions")]
        public List<Permissions> GetAllPermissions()
        {
            return permissionsService.GetAllPermissions();
        }
    }
}
