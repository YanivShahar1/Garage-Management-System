using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public class MotorcycleBuilder : VehicleBuilder
    {
        private Motorcycle Motorcycle => (Motorcycle)Vehicle;

        public MotorcycleBuilder(Motorcycle motorcycle) : base(motorcycle)
        {
        }

        public override VehicleBuilder WithVehicleInfo(VehicleInfo vehicleInfo)
        {
            Motorcycle.Info = vehicleInfo;
            return this;
        }
        public MotorcycleBuilder WithLicenseType(Motorcycle.eMotorcycleLicenseType licenseType)
        {
            Motorcycle.LicenseType = licenseType;
            return this;
        }

        public override Vehicle Build()
        {
            return Motorcycle;
        }
    }
}
