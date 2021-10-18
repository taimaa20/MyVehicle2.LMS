using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public interface IVehicleRepoisitory
    {
        public bool InsertVehicles(Vehicles Veh);
        public bool UpdateVehicles(Vehicles Veh);
        public bool DeleteVehicles(int VehicleId);
        public List<Vehicles> GetAllVehicles();
        public Vehicles GetVehicleById(int VehicleId);
    }
}
