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
    public class ReportTypeController : ControllerBase
    {
        private readonly IReportTypeService reportTypeService;
        public ReportTypeController(IReportTypeService reportTypeService)
        {
            this.reportTypeService = reportTypeService;
        }
        [HttpDelete("delete")]

        public bool DeleteReportType([FromBody] ReportType reportType)
        {
            return reportTypeService.DeleteReportType(reportType);
        }
        [HttpPost]
        public bool InsertReportType([FromBody] ReportType reportType)
        {
            return reportTypeService.InsertReportType(reportType);
        }
    }
}
