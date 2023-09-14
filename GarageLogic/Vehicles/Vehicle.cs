﻿using System;
using System.Collections.Generic;

using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public abstract class Vehicle
    {
        public VehicleInfo Info { get; }
        public EnergySystem EnergySystem { get; }
        public abstract List<Wheel> Wheels { get; }

        internal Vehicle(VehicleInfo vehicleInfo, EnergySystem energySystem)
        {
            Info = vehicleInfo;
            EnergySystem = energySystem ?? throw new ArgumentNullException(nameof(energySystem), "Energy system cannot be null.");
        }

    }
}