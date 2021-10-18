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
  public  class VehicleRepoisitory: IVehicleRepoisitory
    {
        private readonly IDBContext dBContext;
        public VehicleRepoisitory(IDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public bool InsertVehicles(Vehicles Veh)
        {
            var VehParameter=new DynamicParameters();
            VehParameter.Add("@VehicleName", Veh.VehicleName, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleModel", Veh.VehicleModel, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleColor", Veh.VehicleColor, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleCategory", Veh.VehicleCategory, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@UseType", Veh.UseType, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@RegisterType", Veh.RegisterType, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@LicenseNumber", Veh.LicenseNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@LicenseExpiry", Veh.LicenseExpiry, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            VehParameter.Add("@EngineCapacity", Veh.EngineCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            VehParameter.Add("@EngineType", Veh.EngineType, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@MadeYear", Veh.MadeYear, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            VehParameter.Add("@LicensingCenter", Veh.LicensingCenter, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@ChassisNumber", Veh.ChassisNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@EngineNumber", Veh.EngineNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@Address", Veh.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@UserId", Veh.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            VehParameter.Add("@LicenseValueId", Veh.LicenseValueId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("InsertVehicles", VehParameter, commandType: CommandType.StoredProcedure);
            return true;

        }
        public bool UpdateVehicles(Vehicles Veh)
        {
            var VehParameter = new DynamicParameters();
            VehParameter.Add("@VehicleId", Veh.VehicleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleName", Veh.VehicleName, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleModel", Veh.VehicleModel, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleColor", Veh.VehicleColor, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@VehicleCategory", Veh.VehicleCategory, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@UseType", Veh.UseType, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@RegisterType", Veh.RegisterType, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@LicenseNumber", Veh.LicenseNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@LicenseExpiry", Veh.LicenseExpiry, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            VehParameter.Add("@EngineCapacity", Veh.EngineCapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            VehParameter.Add("@EngineType", Veh.EngineType, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@MadeYear", Veh.MadeYear, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            VehParameter.Add("@LicensingCenter", Veh.LicensingCenter, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@ChassisNumber", Veh.ChassisNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@EngineNumber", Veh.EngineNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@Address", Veh.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            VehParameter.Add("@UserId", Veh.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            VehParameter.Add("@LicenseValueId", Veh.LicenseValueId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("InsertVehicles", VehParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteVehicles(int VehicleId)
        {
            var VehParameter = new DynamicParameters();
            VehParameter.Add("@VehicleId", VehicleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.ExecuteAsync("DeleteVehicles", VehParameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Vehicles> GetAllVehicles()
        {
            IEnumerable<Vehicles>
            Result = dBContext.Connection.Query<Vehicles>("GetAllVehicles", commandType: CommandType.StoredProcedure);
            return Result.ToList();

        }
        public Vehicles GetVehicleById(int VehicleId)
        {
            var VehParameter = new DynamicParameters();
            VehParameter.Add("@VehicleId", VehicleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var Result = dBContext.Connection.Query<Vehicles>("GetVehicleById", VehParameter, commandType: CommandType.StoredProcedure);
            return Result.FirstOrDefault();
        }
    }
}

