using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle { get; set; }

        public VehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public abstract Vehicle Build();
        public abstract VehicleBuilder WithVehicleInfo(VehicleInfo vehicleInfo);
    }
}
