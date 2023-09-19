using System;
using System.Collections.Generic;

using GarageLogic.Energy;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public abstract class Vehicle
    {
        public VehicleInfo Info { get; }
        public EnergySystem EnergySystem { get; }
        public abstract List<Wheel> Wheels { get; }
        protected Vehicle(VehicleInfo vehicleInfo, EnergySystem energySystem)
        {
            Info = vehicleInfo;
            EnergySystem = energySystem ?? throw new ArgumentNullException(nameof(energySystem), "Energy system cannot be null.");
        }

    }
}