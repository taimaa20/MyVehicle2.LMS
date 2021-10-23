using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.DTO;
using MyVehicle.LMS.CORE.Repoisitory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MyVehicle.LMS.INFRA.Repoisitory
{
    public class UsersRepoisitory : IUsersRepoisitory
    {
        private readonly IDBContext dBContext;
        public UsersRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IEnumerable<CountUserCars> CountUserCars(int id)
        {
                var par = new DynamicParameters();
                par.Add("@UserId", id, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);
                IEnumerable<CountUserCars> result = dBContext.Connection.Query<CountUserCars>("CountUserCars", commandType: CommandType.StoredProcedure);
                return result.ToList();

        }

        public bool DeleteUsers(Users users)
        {
            var Parameters = new DynamicParameters();

            Parameters.Add("@UserId", users.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateUsers", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<EmployeesSalaries> EmployeesSalaries()
        {
            IEnumerable<EmployeesSalaries> reselt = dBContext.Connection.Query<EmployeesSalaries>("EmployeesSalaries", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public List<Users> GetAllUsers()
        {
            IEnumerable<Users> reselt = dBContext.Connection.Query<Users>("GetAllUsers", commandType: CommandType.StoredProcedure);

            return reselt.ToList();
        }

        public Users GetAllUsersById(Users users)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@UserId", users.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var reselt = dBContext.Connection.Query<Users>("GetAllUsersById", Parameter, commandType: CommandType.StoredProcedure);

            return reselt.FirstOrDefault();
        }

        public bool InsertUsers(Users users)
        {
            var Parameters = new DynamicParameters();
            Parameters.Add("@FullName", users.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@UserImage", users.UserImage, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Gender", users.Gender, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            Parameters.Add("@Age", users.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@Email", users.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@PhoneNumber", users.PhoneNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            
            Parameters.Add("@Address", users.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            
            
            Parameters.Add("@SettingId", users.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@loginId", users.loginId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("InsertUsers", Parameters, commandType: CommandType.StoredProcedure);
            return true;

        }

        public IEnumerable<NumberOfEmployees> NumberOfEmployees()
        {
            IEnumerable<NumberOfEmployees> result = dBContext.Connection.Query<NumberOfEmployees>("NumberOfEmployees", commandType: CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<NumberOfUsers> NumberOfUsers()
        {
            IEnumerable<NumberOfUsers> result =dBContext.Connection.Query<NumberOfUsers>("NumberOfUsers", commandType: CommandType.StoredProcedure);
            return result;
        }

        public List<VehiclesUsers> SearchByUserId(SearchByUserId searchByUserId)
        {
            var Parameter = new DynamicParameters();
            Parameter.Add("@UserId", searchByUserId.UserId, dbType: DbType.Int32, direction: System.Data.ParameterDirection.Input);

            IEnumerable<VehiclesUsers> result = dBContext.Connection.Query<VehiclesUsers>("SearchByUserId", Parameter, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public bool UpdateUsers(Users users)
        {
            var Parameters = new DynamicParameters();
            
            Parameters.Add("@UserId", users.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@FullName", users.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@UserImage", users.UserImage, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@Gender", users.Gender, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            Parameters.Add("@Age", users.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@Email", users.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            Parameters.Add("@PhoneNumber", users.PhoneNumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            
            Parameters.Add("@Address", users.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            
            
            Parameters.Add("@SettingId", users.SettingId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            Parameters.Add("@loginId", users.loginId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateUsers", Parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<GetDrivingLicenseDTO> GetDrivingLicense()
        {
            IEnumerable<GetDrivingLicenseDTO>
            Reselt = dBContext.Connection.Query<GetDrivingLicenseDTO>("GetDrivingLicense", commandType: CommandType.StoredProcedure);
            return Reselt.ToList();

        }
        public List<ObtainFinancialReportsDTO> ObtainFinancialReports()
        {
            IEnumerable<ObtainFinancialReportsDTO>
            Reselt = dBContext.Connection.Query<ObtainFinancialReportsDTO>("ObtainFinancialReports", commandType: CommandType.StoredProcedure);
            return Reselt.ToList();

        }
        public List<ViewUserContactInformationDTO> ViewUserContactInformation(DateTime PaymentDate)
        {
            var UParameter = new DynamicParameters();
            UParameter.Add("@PaymentDate", PaymentDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var Reselt = dBContext.Connection.Query<ViewUserContactInformationDTO>("ViewUserContactInformation", UParameter, commandType: CommandType.StoredProcedure);

            return Reselt.ToList();
        }

    }
}
