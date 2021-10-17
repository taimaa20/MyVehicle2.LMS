﻿using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
  public  interface IContactService
    {
        public bool InsertContact(Contact contact);
        public bool UpdateContact(Contact contact);
        public bool DeleteContact(Contact contact);
        public List<Contact> GetAllContact();
    }
}
