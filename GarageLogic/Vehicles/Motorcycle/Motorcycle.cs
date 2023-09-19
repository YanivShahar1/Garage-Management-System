using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;
using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public enum eMotorcycleLicenseType
        {
            A1,
            A2,
            AA,
            B1
        }

        private const int NumberOfWheels = 2;
        private const float MaxAirPressure = 31.0f;
        public eMotorcycleLicenseType LicenseType { get; set; }

        protected Motorcycle(VehicleInfo vehicleInfo, eMotorcycleLicenseType licenseType)
            : base(vehicleInfo)
        {
            LicenseType = licenseType;
        }

        public override List<Wheel> Wheels { get; } = InitializeMotorcycleWheels();

        private static List<Wheel> InitializeMotorcycleWheels()
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
