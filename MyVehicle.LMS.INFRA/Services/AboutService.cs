﻿using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository aboutRepository;
        public AboutService(AboutRepository aboutRepository)
        {
            this.aboutRepository = aboutRepository;
        }
        public bool DeleteAbout(About about)
        {
            return aboutRepository.DeleteAbout(about);
        }

        public List<About> GetAllAbout()
        {
            return aboutRepository.GetAllAbout();
        }

        public bool InsertAbout(About about)
        {
            return aboutRepository.InsertAbout(about);
        }

        public bool UpdateAbout(About about)
        {
            return aboutRepository.UpdateAbout(about);
        }
    }
}
