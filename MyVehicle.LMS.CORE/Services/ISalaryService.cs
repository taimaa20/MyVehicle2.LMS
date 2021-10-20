using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
     public interface ISalaryService
    {
        public bool InsertSalary(Salary1 salary);
        public bool UpdateSalary(Salary1 salary);
        public bool DeleteSalary(Salary1 salary);
        public List<Salary1> GetAllSalary();
        public Salary1 GetSalaryById(Salary1 salary);
    }
}
