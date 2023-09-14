using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageLogic.Vehicles
{
    public struct VehicleInfo
    {
        public string Model { get; }
        public int Year { get; }
        public string LicenseNumber { get; }

        public VehicleInfo(string model, int year, string licenseNumber, string ownerName, string ownerPhone)
        {
            Model = model ?? throw new ArgumentNullException(nameof(model), "Model cannot be null.");
            Year = year;
            LicenseNumber = licenseNumber ?? throw new ArgumentNullException(nameof(licenseNumber), "License number cannot be null.");
        }
    }
}
