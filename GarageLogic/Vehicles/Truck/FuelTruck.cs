using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class FuelTruck : Truck
    {
        private const FuelEnergySystem.eFuelType defaultFuelType = FuelEnergySystem.eFuelType.Soler;
        private const float defaultMaxFuelCapacity = 135.0f;

        public FuelTruck(string model, int year, string licenseNumber, bool containDangerousSubstances, float cargo)
            : base(model, year, licenseNumber, new FuelEnergySystem(defaultMaxFuelCapacity, defaultFuelType), containDangerousSubstances, cargo)
        {
        }
    }
}
