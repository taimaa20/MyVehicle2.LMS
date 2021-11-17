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

        [HttpDelete ("delete/{id}")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteUsers(int id)
        {
            return usersService.DeleteUsers(id );
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
        [Route("GetAllUsersById/{id}")]
        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Users GetAllUsersById(int id)
        {
            return usersService.GetAllUsersById(id);
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
        [Route("GetDrivingLicense/{UserId}")]
        [ProducesResponseType(typeof(List<GetDrivingLicenseDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetDrivingLicenseDTO> GetDrivingLicense(int UserId)
        {
            return usersService.GetDrivingLicense(UserId);
        }
        [HttpGet]
        [Route("ObtainFinancialReports")]
        [ProducesResponseType(typeof(List<ObtainFinancialReportsDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports()
        {
            return usersService.ObtainFinancialReports();
        }
        [HttpPost]
        [Route("ViewUserContactInformation")]
        [ProducesResponseType(typeof(List<ViewUserContactInformationDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ViewUserContactInformationDTO> ViewUserContactInformation([FromBody] ViewUserContactInformationDTO paymentDate)
        {
            return usersService.ViewUserContactInformation(paymentDate);
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
        public List<VehiclesUsers> SearchByUserId([FromBody]SearchByUserId searchByUserId)
        {
            return usersService.SearchByUserId(searchByUserId);

        }

       

        [HttpGet]
        [Route("CountUserCars")]

        [ProducesResponseType(typeof(List<Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<CountUserCars> CountUserCars([FromBody]SearchByUserId searchByUserId)
        {
            return usersService.CountUserCars(searchByUserId);

        }
        [HttpGet]
        [Route("GetListOfEmployees")]

        [ProducesResponseType(typeof(List<ListOfEmployees>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ListOfEmployees> GetListOfEmployees()
        {
            return usersService.GetListOfEmployees();
        }
        [HttpGet]
        [Route("GetNumberOfAllUser")]

        [ProducesResponseType(typeof(List<NumberOfAllUser>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<NumberOfAllUser> GetNumberOfAllUser()
        {
            return usersService.GetNumberOfAllUser();
        }
    }
}
