using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class Car : Vehicle
    {
        public enum eColor
        {
            Red,
            Blue,
            Green,
            Yellow
        }

        public enum eNumberOfDoors
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }

        public eColor Color { get; set; }
        public eNumberOfDoors NumberOfDoors { get; set; }

        internal Car(string model, int year, string licenseNumber, EnergySystem energySystem, eColor color, eNumberOfDoors numberOfDoors)
            : base(model, year, licenseNumber, energySystem)
        {
            Color = color;
            NumberOfDoors = numberOfDoors;
        }

        // Override the abstract members from the Vehicle class
        public override int NumberOfWheels => 5; // Typically, a car has 4 wheels and one backup wheel.

        public override List<Wheel> Wheels { get; } = new List<Wheel>(); // You can initialize this as needed or provide methods to add wheels.
    }
}
