using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
   public class NewCarLicensingService
    {
        private readonly INewCarLicensingRepository newCarLicensingRepository;
        public NewCarLicensingService(NewCarLicensingRepository newCarLicensingRepository)
        {
            this.newCarLicensingRepository = newCarLicensingRepository;
        }
    }
}
