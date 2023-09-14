using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class Truck : Vehicle
    {
        private const int NumberOfWheels = 14;
        private const float MaxAirPressure = 26.0f;
        public bool ContainsDangerousSubstances { get; }
        public double CargoVolume { get; } // Representing cargo volume in cubic meters.

        internal Truck(VehicleInfo vehicleInfo, EnergySystem energySystem, bool containsDangerousSubstances, double cargoVolume)
            : base(vehicleInfo, energySystem)
        {
            ContainsDangerousSubstances = containsDangerousSubstances;
            CargoVolume = cargoVolume;
        }



        public override List<Wheel> Wheels { get; } = InitializeTruckWheels();

        private static List<Wheel> InitializeTruckWheels()
        {
            List<Wheel> wheels = new List<Wheel>();
            for (int i = 0; i < NumberOfWheels; i++)
            {
                wheels.Add(new Wheel(maxAirPressure: MaxAirPressure));
            }
            return wheels;
        }
    }
}
