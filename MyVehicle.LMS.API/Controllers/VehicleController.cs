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
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }
        [HttpPost]
        [Route("InsertVehicles")]
        public bool InsertVehicles([FromBody]Vehicles Veh)
        {
            return vehicleService.InsertVehicles(Veh);
        }
        [HttpPut]
        [Route("UpdateVehicles")]
        public bool UpdateVehicles(Vehicles Veh)
        {
            return vehicleService.UpdateVehicles(Veh);
        }
        [HttpDelete]
        [Route("DeleteVehicles")]
        public bool DeleteVehicles(int VehicleId)
        {
            return vehicleService.DeleteVehicles(VehicleId);
        }
        [HttpGet]
        [Route("GetAllVehicles")]
        public List<Vehicles> GetAllVehicles()
        {
            return vehicleService.GetAllVehicles();
        }
        [HttpGet]
        [Route("GetVehicleById/{VehicleId}")]
        public Vehicles GetVehicleById(int VehicleId)
        {
            return vehicleService.GetVehicleById(VehicleId);
        }

        [HttpPost]
        [Route("SearchingForVehiclesLicenseExpiry")]
        [ProducesResponseType(typeof(List<VehiclesUsersLicenseExpiry>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<VehiclesUsersLicenseExpiry> SearchingForVehiclesLicenseExpiry([FromBody]SearchingForVehiclesLicenseExpiry searchingForVehiclesLicenseExpiry)
        {
            return vehicleService.SearchingForVehiclesLicenseExpiry(searchingForVehiclesLicenseExpiry);
        }


        [HttpPost]
        [Route("SearchByVehicleCategory")]
        [ProducesResponseType(typeof(List<VehiclesUsersLicenseExpiry>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<VehiclesUsers> SearchByVehicleCategory(SearchByVehicleCategory searchByVehicleCategory)
        {
            return vehicleService.SearchByVehicleCategory(searchByVehicleCategory);
        }

        [HttpGet]
        [Route("VehicleSystemReport")]
        public List<VehicleSystemReport> VehicleSystemReport()
        {
            return vehicleService.VehicleSystemReport();
        }
        [HttpGet]
        [Route("SearchByVehicleCategory")]
        [ProducesResponseType(typeof(List<VehiclesUsersLicenseExpiry>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<VehicleSystemReportBetween> VehicleSystemReportBetween(VehicleSystemReportBetween vehicleSystemReportBetween)
        {
            return vehicleService.VehicleSystemReportBetween(vehicleSystemReportBetween);
        }
    }

}

