using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface ITaskJobRepoisitory
    {
        public bool InsertTaskJob(TaskJob Task);
        public bool UpdateTaskJob(TaskJob Task);
        public bool DeleteTaskJob(int TaskId);
        public List<TaskJob> GetAllTaskJob();
    }
}
