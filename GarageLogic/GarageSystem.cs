using System;
using System.Collections.Generic;
using System.Linq;

using GarageLogic.Vehicles;

namespace GarageLogic
{
    public class GarageSystem
    {
        private List<Vehicle> vehicles;

        public GarageSystem()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle), "Vehicle cannot be null.");
            }

            if (IsVehicleInGarage(vehicle.Info.LicenseNumber))
            {
                throw new InvalidOperationException("A vehicle with the same license number already exists in the garage.");
            }

            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(string licenseNumber)
        {
            var vehicleToRemove = GetVehicleByLicenseNumber(licenseNumber);
            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
            }
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles.ToList();
        }

        public Vehicle GetVehicleByLicenseNumber(string licenseNumber)
        {
            return vehicles.FirstOrDefault(vehicle => vehicle.Info.LicenseNumber == licenseNumber);
        }

        public bool IsVehicleInGarage(string licenseNumber)
        {
            return vehicles.Any(vehicle => vehicle.Info.LicenseNumber == licenseNumber);
        }
    }
}
