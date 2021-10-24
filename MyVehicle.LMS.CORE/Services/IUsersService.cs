﻿using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
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

        public List<GetDrivingLicenseDTO> GetDrivingLicense();
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports();
        public List<ViewUserContactInformationDTO> ViewUserContactInformation(ViewUserContactInformationDTO paymentDate);


        //Retrieve Number of users //Admin
        public IEnumerable<NumberOfUsers> NumberOfUsers();

        //Retrieve Number of Employee //Admin
        public IEnumerable<NumberOfEmployees> NumberOfEmployees();

        //Retrieve Employees Salaries //Admin
        public List<EmployeesSalaries> EmployeesSalaries();

        //Search By UserId  //Users
        public List<VehiclesUsers> SearchByUserId(SearchByUserId searchByUserId);

        //CountUserCars //Users
        public IEnumerable<CountUserCars> CountUserCars(SearchByUserId searchByUserId);
        //List of Employee  // Admin

        public List<ListOfEmployees> GetListOfEmployees();

        // Retrive Number of AllUsers
        public IEnumerable<NumberOfAllUser> GetNumberOfAllUser();



    }
}
