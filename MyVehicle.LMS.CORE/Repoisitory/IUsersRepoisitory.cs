﻿using MyVehicle.LMS.CORE.Data;
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
        public bool DeleteUsers(int id);
        public List<Users> GetAllUsers();
        public Users GetAllUsersById(int id );

        public List<GetDrivingLicenseDTO> GetDrivingLicense(int UserId);
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
        //List of Employee in Admin
        public List<ListOfEmployees> GetListOfEmployees();
        // Retrive Number of AllUsers
        public IEnumerable<NumberOfAllUser> GetNumberOfAllUser();

     






    }
}
