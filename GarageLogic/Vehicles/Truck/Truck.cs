using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class Truck : Vehicle
    {
        public bool ContainsDangerousSubstances { get; }
        public double CargoVolume { get; } // Representing cargo volume in cubic meters.

        internal Truck(string model, int year, string licenseNumber, EnergySystem energySystem, bool containsDangerousSubstances, double cargoVolume)
            : base(model, year, licenseNumber, energySystem)
        {
            ContainsDangerousSubstances = containsDangerousSubstances;
            CargoVolume = cargoVolume;
        }

        public override int NumberOfWheels => 6; // Typically, a truck has 6 wheels.

        public override List<Wheel> Wheels { get; } = new List<Wheel>(); // You can initialize this as needed or provide methods to add wheels.

        public override string ToString()
        {
            return $"{Year} {Model} (License: {LicenseNumber}) - Cargo Volume: {CargoVolume} cubic meters";
        }
    }
}
