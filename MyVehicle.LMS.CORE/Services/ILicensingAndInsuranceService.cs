using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
   public  interface ILicensingAndInsuranceService
    {
        public bool InsertLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance);
        public bool UpdateLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance);

        public List<LicensingAndInsurance> GetAllLicensingAndInsurance();
    }
}
