using System;
using GarageLogic.Vehicles;

namespace GarageLogic
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicle(eVehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case eVehicleType.Car:
                    return new Car();
                case eVehicleType.Truck:
                    return new Truck();
                // ... handle other vehicle types as they're added
                default:
                    throw new ArgumentException($"Unsupported vehicle type: {vehicleType}", nameof(vehicleType));
            }
        }
    }
}
