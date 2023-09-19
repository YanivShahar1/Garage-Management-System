using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;
using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class ElectricMotorcycle : Motorcycle
    {
        private const float defaultMaxBatteryCapacity = 2.6f;

        public ElectricMotorcycle(VehicleInfo vehicleInfo, eMotorcycleLicenseType licenseType)
            : base(
                  vehicleInfo,
                  licenseType)
        {
            this.EnergySystem = new ElectricEnergySystem(defaultMaxBatteryCapacity);
        }
    }
}
