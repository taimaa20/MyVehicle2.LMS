using Dapper;
using MyVehicle.LMS.CORE.Common;
using MyVehicle.LMS.CORE.Data;
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
        public bool DeleteUsers(Users users)
        {
            var Parameters = new DynamicParameters();

            Parameters.Add("@UserId", users.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
            var Reselt = dBContext.Connection.ExecuteAsync("UpdateUsers", Parameters, commandType: CommandType.StoredProcedure);
            return true;
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

      
    }
}
