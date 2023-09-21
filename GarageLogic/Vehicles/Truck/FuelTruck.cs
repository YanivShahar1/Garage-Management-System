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
        public const float MaxFuelCapacityLiters = 135.0f;

        public FuelTruck()
        {
            this.EnergySystem = new FuelEnergySystem(MaxFuelCapacityLiters, defaultFuelType);
        }
    }
}
