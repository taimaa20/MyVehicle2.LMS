using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpDelete("delete")]

        public bool DeleteContact([FromBody] Contact contact)
        {
            return contactService.DeleteContact(contact);
        }
        [HttpGet]
        [Route("GetAllContact")]
        public List<Contact> GetAllContact()
        {
            return contactService.GetAllContact();
        }
        [HttpPost]
        public bool InsertContact([FromBody] Contact contact)
        {
            return contactService.InsertContact(contact);
        }
        [HttpPut]
        public bool UpdateContact([FromBody] Contact contact)
        {
            return contactService.UpdateContact(contact);
        }
    }
}
