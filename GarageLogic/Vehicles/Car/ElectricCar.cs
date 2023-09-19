﻿using GarageLogic.Energy;
using GarageLogic.Info;
namespace GarageLogic.Vehicles
{
    public class ElectricCar : Car
    {
        private const float defaultMaxBatteryCapacity = 5.2f;

        public ElectricCar(VehicleInfo vehicleInfo )
            : base(vehicleInfo )
        {
            this.EnergySystem = new ElectricEnergySystem(defaultMaxBatteryCapacity);
        }
    }
}
