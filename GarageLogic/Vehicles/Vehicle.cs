using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;
namespace GarageLogic.Vehicles
{
    public abstract class Vehicle
    {
        public string Model { get; }
        public int Year { get; }
        public string LicenseNumber { get; }
        public abstract int NumberOfWheels { get; }
        public EnergySystem EnergySystem { get; }
        public abstract List<Wheel> Wheels { get; }

        internal Vehicle(string model, int year, string licenseNumber, EnergySystem energySystem)
        {
            Model = model ?? throw new ArgumentNullException(nameof(model), "Model cannot be null.");
            Year = year;
            LicenseNumber = licenseNumber ?? throw new ArgumentNullException(nameof(licenseNumber), "License number cannot be null.");
            EnergySystem = energySystem ?? throw new ArgumentNullException(nameof(energySystem), "Energy system cannot be null.");
        }

        public override string ToString()
        {
            return $"{Year} {Model} (License: {LicenseNumber})";
        }
    }
}