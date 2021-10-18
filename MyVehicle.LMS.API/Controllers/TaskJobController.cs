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
    public class TaskJobController : ControllerBase
    {
        private readonly ITaskJobServices taskJobServices;
        public TaskJobController(ITaskJobServices taskJobServices)
        {
            this.taskJobServices = taskJobServices;
        }
        [HttpPost]
        [Route("InsertTaskJob")]
        public bool InsertTaskJob([FromBody]TaskJob Task)
        {
            return taskJobServices.InsertTaskJob(Task);
        }
        [HttpPut]
        [Route("UpdateTaskJob")]
        public bool UpdateTaskJob(TaskJob Task)
        {
            return taskJobServices.UpdateTaskJob(Task);
        }
        [HttpDelete]
        [Route("DeleteTaskJob")]
        public bool DeleteTaskJob(int TaskId)
        {
            return taskJobServices.DeleteTaskJob(TaskId);
        }
        [HttpGet]
        [Route("GetAllTaskJob")]

        public List<TaskJob> GetAllTaskJob()
        {
            return taskJobServices.GetAllTaskJob();


        }

    }

}
