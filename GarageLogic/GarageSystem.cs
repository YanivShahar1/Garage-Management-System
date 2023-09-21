using System;
using System.Collections.Generic;
using System.Linq;

using GarageLogic.Vehicles;
using GarageLogic.Info;

namespace GarageLogic
{
    /// <summary>
    /// Represents a garage for storing and managing vehicles.
    /// </summary>
    public sealed class GarageSystem
    {
        private static GarageSystem instance;
        private static readonly object lockObject = new object();

        private readonly Dictionary<string, Vehicle> vehiclesByLicense;
        private readonly Dictionary<string, OwnerInfo> OwnerByLicense;
        private GarageSystem()
        {
            vehiclesByLicense = new Dictionary<string, Vehicle>();
            OwnerByLicense = new Dictionary<string, OwnerInfo>();
        }

        /// <summary>
        /// Gets the single instance of the <see cref="GarageSystem"/> class.
        /// </summary>
        public static GarageSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new GarageSystem();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Adds a vehicle to the garage.
        /// </summary>
        /// <param name="ownerInfo">The information about the owner of the vehicle.</param>
        /// <param name="vehicle">The vehicle to add.</param>
        /// <exception cref="InvalidOperationException">Thrown if a vehicle with the same license number already exists in the garage.</exception>
        public void AddVehicle(Vehicle vehicle, OwnerInfo ownerInfo)
        {
            if (vehicle == null || ownerInfo == null)
            {
                throw new ArgumentNullException("Vehicle and ownerInfo cannot be null.");
            }
            lock (lockObject)
            {

                if (IsVehicleInGarage(vehicle.Info.LicenseNumber))
                {
                    throw new InvalidOperationException("A vehicle with the same license number already exists in the garage.");
                }

                vehiclesByLicense[vehicle.Info.LicenseNumber] = vehicle;
                OwnerByLicense[vehicle.Info.LicenseNumber] = ownerInfo;
            }
        }


        /// <summary>
        /// Removes a vehicle from the garage by its license number.
        /// </summary>
        /// <param name="licenseNumber">The license number of the vehicle to remove.</param>
        public void RemoveVehicle(string licenseNumber)
        {
            if (IsVehicleInGarage(licenseNumber))
            {
                lock (lockObject)
                {
                    if (IsVehicleInGarage(licenseNumber))
                    {
                        vehiclesByLicense.Remove(licenseNumber);
                        OwnerByLicense.Remove(licenseNumber);
                    }
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
                return new List<Vehicle>(vehiclesByLicense.Values);
            }
        }

        /// <summary>
        /// Gets a vehicle from the garage by its license number.
        /// </summary>
        /// <param name="licenseNumber">The license number of the vehicle to retrieve.</param>
        /// <returns>The vehicle with the specified license number, or null if not found.</returns>
        public Vehicle GetVehicleByLicenseNumber(string licenseNumber)
        {
            if (IsVehicleInGarage(licenseNumber))
            {
                lock (lockObject)
                {
                    if (IsVehicleInGarage(licenseNumber))
                    {
                        return vehiclesByLicense[licenseNumber];
                    }
                    
                }

            }
            return null;
        }

        public bool IsVehicleInGarage(string licenseNumber)
        {
            lock (lockObject)
            {
                return vehiclesByLicense.ContainsKey(licenseNumber);
            }
        }

        public OwnerInfo GetOwnerInfo(string licenseNumber)
        {
            if (IsVehicleInGarage(licenseNumber))
            {
                lock (lockObject)
                {
                    if (IsVehicleInGarage(licenseNumber))
                    {
                        return OwnerByLicense[licenseNumber];
                    }
                }
            }
            return null;
        }
    }
}
