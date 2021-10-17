using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public interface ILicensingService
    {
        public List<Licensing> GetAllLicensing();

        public bool InsertLicensing(Licensing licensing);
        public bool UpdateLicensing(Licensing licensing);
    }
}
