using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        public VehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public abstract Vehicle Build();
        public abstract VehicleBuilder WithVehicleInfo(VehicleInfo vehicleInfo);
    }
}
