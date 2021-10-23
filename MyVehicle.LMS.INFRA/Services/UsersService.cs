using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public  class UsersService: IUsersService
    {
        private readonly IUsersRepoisitory usersRepoisitory;
        public UsersService(IUsersRepoisitory usersRepoisitory)
        {
            this.usersRepoisitory = usersRepoisitory;
        }

        public bool DeleteUsers(Users users)
        {
            return usersRepoisitory.DeleteUsers(users);
        }

        public List<Users> GetAllUsers()
        {
            return usersRepoisitory.GetAllUsers();
        }

        public Users GetAllUsersById(Users users)
        {
            return usersRepoisitory.GetAllUsersById(users);
        }

        public bool InsertUsers(Users users)
        {
            return usersRepoisitory.InsertUsers(users);
        }

        public bool UpdateUsers(Users users)
        {
            return usersRepoisitory.UpdateUsers(users);
        }
        public List<GetDrivingLicenseDTO> GetDrivingLicense()
        {
            return usersRepoisitory.GetDrivingLicense();
        }
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports()
        {
            return usersRepoisitory.ObtainFinancialReports();
        }
        public List<ViewUserContactInformationDTO> ViewUserContactInformation(DateTime PaymentDate)
        {
            return usersRepoisitory.ViewUserContactInformation(PaymentDate);
        }


    }
}
