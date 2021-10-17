using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Services
{
  public  interface IUsersService
    {
        public bool InsertUsers(Users users);
        public bool UpdateUsers(Users users);
        public bool DeleteUsers(Users users);
        public List<Users> GetAllUsers();
        public Users GetAllUsersById(Users users);
    }
}
