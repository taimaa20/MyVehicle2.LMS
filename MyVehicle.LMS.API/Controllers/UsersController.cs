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
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpDelete ("delete")]
        public bool DeleteUsers([FromBody] Users users)
        {
            return usersService.DeleteUsers(users);
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public List<Users> GetAllUsers()
        {
            return usersService.GetAllUsers();
        }
        [HttpGet]
        [Route("GetAllUsersById")]
        public Users GetAllUsersById(Users users)
        {
            return usersService.GetAllUsersById(users);
        }
        [HttpPost]
        public bool InsertUsers([FromBody] Users users)
        {
            return usersService.InsertUsers(users);
        }
        [HttpPut]
        public bool UpdateUsers([FromBody] Users users)
        {
            return usersService.UpdateUsers(users);
        }
    }
}
