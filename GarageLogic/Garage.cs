using System;
using System.Collections.Generic;
using System.Linq;

using GarageLogic.Vehicles;

namespace GarageLogic
{
    /// <summary>
    /// Represents a garage for storing and managing vehicles.
    /// </summary>
    public sealed class Garage
    {
        private static Garage instance;
        private static readonly object lockObject = new object();

        private List<Vehicle> vehicles;

        private Garage()
        {
            vehicles = new List<Vehicle>();
        }

        /// <summary>
        /// Gets the single instance of the <see cref="Garage"/> class.
        /// </summary>
        public static Garage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Garage();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Adds a vehicle to the garage.
        /// </summary>
        /// <param name="vehicle">The vehicle to add.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="vehicle"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown if a vehicle with the same license number already exists in the garage.</exception>
        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new ArgumentNullException(nameof(vehicle), "Vehicle cannot be null.");
            }

            lock (lockObject)
            {
                if (IsVehicleInGarage(vehicle.Info.LicenseNumber))
                {
                    throw new InvalidOperationException("A vehicle with the same license number already exists in the garage.");
                }

                vehicles.Add(vehicle);
            }
        }

        /// <summary>
        /// Removes a vehicle from the garage by its license number.
        /// </summary>
        /// <param name="licenseNumber">The license number of the vehicle to remove.</param>
        public void RemoveVehicle(string licenseNumber)
        {
            lock (lockObject)
            {
                var vehicleToRemove = GetVehicleByLicenseNumber(licenseNumber);
                if (vehicleToRemove != null)
                {
                    vehicles.Remove(vehicleToRemove);
                }
            }
        }

        /// <summary>
        /// Gets a list of all vehicles currently in the garage.
        /// </summary>
        /// <returns>A list of vehicles.</returns>
        public List<Vehicle> GetVehicles()
        {
            lock (lockObject)
            {
                return vehicles.ToList();
            }
        }

        /// <summary>
        /// Gets a vehicle from the garage by its license number.
        /// </summary>
        /// <param name="licenseNumber">The license number of the vehicle to retrieve.</param>
        /// <returns>The vehicle with the specified license number, or null if not found.</returns>
        public Vehicle GetVehicleByLicenseNumber(string licenseNumber)
        {
            lock (lockObject)
            {
                return vehicles.FirstOrDefault(vehicle => vehicle.Info.LicenseNumber == licenseNumber);
            }
        }

        /// <summary>
        /// Checks if a vehicle with the specified license number is in the garage.
        /// </summary>
        /// <param name="licenseNumber">The license number to check.</param>
        /// <returns>True if a vehicle with the specified license number is in the garage; otherwise, false.</returns>
        public bool IsVehicleInGarage(string licenseNumber)
        {
            lock (lockObject)
            {
                return vehicles.Any(vehicle => vehicle.Info.LicenseNumber == licenseNumber);
            }
        }
    }

}
