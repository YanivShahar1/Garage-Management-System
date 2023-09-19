using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GarageLogic.Energy;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public class FuelTruck : Truck
    {
        private const FuelEnergySystem.eFuelType defaultFuelType = FuelEnergySystem.eFuelType.Soler;
        private const float defaultMaxFuelCapacity = 135.0f;

        public FuelTruck(VehicleInfo vehicleInfo)
            : base(vehicleInfo)
        {
            this.EnergySystem = new FuelEnergySystem(defaultMaxFuelCapacity, defaultFuelType);
        }
    }
}
