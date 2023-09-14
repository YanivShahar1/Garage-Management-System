using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    internal class CarBuilder
    {
        private string Color { get; set; }
        private int NumberOfDoors { get; set; }
        private EnergySystem EnergySystem { get; set; } // Energy system can be FuelEnergySystem or ElectricEnergySystem.

        internal CarBuilder WithColor(string color)
        {
            Color = color;
            return this;
        }

        internal CarBuilder WithNumberOfDoors(int numberOfDoors)
        {
            NumberOfDoors = numberOfDoors;
            return this;
        }

        internal CarBuilder WithEnergySystem(EnergySystem energySystem)
        {
            EnergySystem = energySystem;
            return this;
        }

        internal Car Build(string model, int year, string licenseNumber)
        {
            if (EnergySystem == null)
            {
                throw new InvalidOperationException("Energy system must be specified for the car.");
            }

            return new Car(model, year, licenseNumber, Color, NumberOfDoors, EnergySystem);
        }
    }

}
