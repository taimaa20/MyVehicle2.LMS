using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
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
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteUsers([FromBody] Users users)
        {
            return usersService.DeleteUsers(users);
        }
        [HttpGet]
        [Route("GetAllUsers")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Users> GetAllUsers()
        {
            return usersService.GetAllUsers();
        }
        [HttpGet]
        [Route("GetAllUsersById")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Users GetAllUsersById(Users users)
        {
            return usersService.GetAllUsersById(users);
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool InsertUsers([FromBody] Users users)
        {
            return usersService.InsertUsers(users);
        }
        [HttpPut]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateUsers([FromBody] Users users)
        {
            return usersService.UpdateUsers(users);
        }

        [HttpGet]
        [Route("GetDrivingLicense")]
        [ProducesResponseType(typeof(List<GetDrivingLicenseDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetDrivingLicenseDTO> GetDrivingLicense()
        {
            return usersService.GetDrivingLicense();
        }
        [HttpGet]
        [Route("ObtainFinancialReports")]
        [ProducesResponseType(typeof(List<ObtainFinancialReportsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports()
        {
            return usersService.ObtainFinancialReports();
        }
        [HttpGet]
        [Route("ViewUserContactInformation/{PaymentDate}")]
        [ProducesResponseType(typeof(List<ViewUserContactInformationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ViewUserContactInformationDTO> ViewUserContactInformation(DateTime PaymentDate)
        {
            return usersService.ViewUserContactInformation(PaymentDate);
        }

        [HttpGet]
        [Route("NumberOfUsers")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<NumberOfUsers> NumberOfUsers()
        {
            return usersService.NumberOfUsers();
        }

        [HttpGet]
        [Route("NumberOfEmployees")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<NumberOfEmployees> NumberOfEmployees()
        {
            return usersService.NumberOfEmployees();

        }


        [HttpGet]
        [Route("EmployeesSalaries")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<EmployeesSalaries> EmployeesSalaries()
        {
            return usersService.EmployeesSalaries();
        }


        [HttpPost]
        [Route("SearchByUserId")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<VehiclesUsers> SearchByUserId(SearchByUserId searchByUserId)
        {
            return usersService.SearchByUserId(searchByUserId);

        }
        [HttpGet]
        [Route("customeritembuyer/{id}")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<CountUserCars> CountUserCars(int id)
        {
            return usersService.CountUserCars(id);

        }
    }
}
