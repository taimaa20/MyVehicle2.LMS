using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
  public  interface IUsersRepoisitory
    {
        
        public bool InsertUsers(Users users);
        public bool UpdateUsers(Users users);
        public bool DeleteUsers(Users users);
        public List<Users> GetAllUsers();
        public Users GetAllUsersById(Users users);

        public List<GetDrivingLicenseDTO> GetDrivingLicense();
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports();
        public List<ViewUserContactInformationDTO> ViewUserContactInformation(DateTime PaymentDate);


        //Retrieve Number of users //Admin
        public IEnumerable<NumberOfUsers> NumberOfUsers();

        //Retrieve Number of Employee //Admin
        public IEnumerable<NumberOfEmployees> NumberOfEmployees();

        //Retrieve Employees Salaries //Admin
        public List<EmployeesSalaries> EmployeesSalaries();

        //Search By UserId  //Users
        public List<VehiclesUsers> SearchByUserId(SearchByUserId searchByUserId);
        //CountUserCars //Users
        public IEnumerable<CountUserCars> CountUserCars(int id);




    }
}
