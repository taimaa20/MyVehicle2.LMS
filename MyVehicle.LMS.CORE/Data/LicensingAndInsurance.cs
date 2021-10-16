using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
   public class LicensingAndInsurance
    {
        [Key]
        public int LicenseValueId { get; set; }
        public double Value { get; set; }
        public int LicensingId { get; set; }
        public int InsuranceId { get; set; }
    }
}
