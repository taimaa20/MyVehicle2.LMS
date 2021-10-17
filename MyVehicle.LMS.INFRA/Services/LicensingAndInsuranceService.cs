﻿using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public   class LicensingAndInsuranceService: ILicensingAndInsuranceService
    {
        private readonly ILicensingAndInsuranceRepository licensingAndInsuranceRepository;
        public LicensingAndInsuranceService(LicensingAndInsuranceRepository licensingAndInsuranceRepository)
        {
            this.licensingAndInsuranceRepository = licensingAndInsuranceRepository;
        }

        public List<LicensingAndInsurance> GetAllLicensingAndInsurance()
        {
            return licensingAndInsuranceRepository.GetAllLicensingAndInsurance();
        }

        public bool InsertLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance)
        {
            return licensingAndInsuranceRepository.InsertLicensingAndInsurance(licensingAndInsurance);
        }

        public bool UpdateLicensingAndInsurance(LicensingAndInsurance licensingAndInsurance)
        {
            return licensingAndInsuranceRepository.UpdateLicensingAndInsurance(licensingAndInsurance);
        }
    }
}
