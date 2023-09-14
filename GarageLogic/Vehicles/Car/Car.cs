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
        private const int numberOfRegularWheels = 4;
        private const int numberOfReserveWheels = 1;
        private const float maxAirPressure = 33.0f;
        public eColor Color { get; set; }
        public eNumberOfDoors NumberOfDoors { get; set; }

        internal Car(VehicleInfo vehicleInfo, EnergySystem energySystem, eColor color, eNumberOfDoors numberOfDoors)
            : base(vehicleInfo, energySystem)
        {
            Color = color;
            NumberOfDoors = numberOfDoors;
        }

        public override List<Wheel> Wheels { get; } = InitializeCarWheels();

        private static List<Wheel> InitializeCarWheels()
        {
            List<Wheel> wheels = new List<Wheel>();
            for (int i = 0; i < numberOfRegularWheels; i++)
            {
                wheels.Add(new Wheel(maxAirPressure: maxAirPressure));
            }
            // Add the reserve wheel
            for (int i = 0; i < numberOfReserveWheels; i++)
            {
                wheels.Add(new Wheel(maxAirPressure: maxAirPressure));
            }
            return wheels;
        }
    }
}
