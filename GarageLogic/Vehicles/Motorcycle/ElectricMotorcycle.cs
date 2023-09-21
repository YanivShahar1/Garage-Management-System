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
        public const float MaxBatteryCapacityKWh = 2.6f;

        public ElectricMotorcycle()
        {
            this.EnergySystem = new ElectricEnergySystem(MaxBatteryCapacityKWh);
        }
    }
}
