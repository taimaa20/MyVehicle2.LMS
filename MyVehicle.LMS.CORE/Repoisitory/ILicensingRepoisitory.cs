using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface ILicensingRepoisitory
    {

        public List<Licensing> GetAllLicensing();

        public bool InsertLicensing(Licensing licensing );
        public bool UpdateLicensing(Licensing licensing );
    }
}
