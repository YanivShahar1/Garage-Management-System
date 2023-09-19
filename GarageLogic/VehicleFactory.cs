using System;
using GarageLogic.Vehicles;
using GarageLogic.Info;

namespace GarageLogic
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle(VehicleInfo vehicleInfo);
    }
}
