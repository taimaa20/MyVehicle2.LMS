using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface ILicensingAndInsuranceRepository
    {
        public bool InsertLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance);
        public bool UpdateLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance);
 
        public List<LicensingAndInsurance> GetAllLicensingAndInsurance();
    }
}
