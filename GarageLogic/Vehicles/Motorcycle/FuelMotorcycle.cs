using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public class FuelMotorcycle : Motorcycle
    {
        private const FuelEnergySystem.eFuelType defaultFuelType = FuelEnergySystem.eFuelType.Octan98;
        private const float defaultMaxFuelCapacity = 6.4f;

        public FuelMotorcycle(VehicleInfo vehicleInfo, eMotorcycleLicenseType licenseType)
            : base(
                  vehicleInfo,
                  new FuelEnergySystem(defaultMaxFuelCapacity, defaultFuelType),
                  licenseType)
        {
        }

    }
}
