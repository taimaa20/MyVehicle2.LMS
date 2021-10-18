﻿using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepoisitory vehicleRepoisitory;
        public VehicleService(IVehicleRepoisitory vehicleRepoisitory)
        {
            this.vehicleRepoisitory = vehicleRepoisitory;
        }
        public bool InsertVehicles(Vehicles Veh)
        {
            return vehicleRepoisitory.InsertVehicles(Veh);
        }
        public bool UpdateVehicles(Vehicles Veh)
        {
            return vehicleRepoisitory.UpdateVehicles(Veh);
        }
        public bool DeleteVehicles(int VehicleId)
        {
            return vehicleRepoisitory.DeleteVehicles(VehicleId);
        }

        public List<Vehicles> GetAllVehicles()
        {
            return vehicleRepoisitory.GetAllVehicles();
        }

        public Vehicles GetVehicleById(int VehicleId)
        {
            return vehicleRepoisitory.GetVehicleById(VehicleId);
        }

       
    }
}