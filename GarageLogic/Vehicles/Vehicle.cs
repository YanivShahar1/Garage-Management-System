using System;
using System.Collections.Generic;

using GarageLogic.Energy;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public abstract class Vehicle
    {
        public VehicleInfo Info { get; internal set; }
        public EnergySystem EnergySystem { get; protected set; }
        public abstract List<Wheel> Wheels { get; }
 
        public void InflateWheels()
        {
            foreach (Wheel wheel in Wheels)
            {
                wheel.InflateToMax();
            }
        }

    }
}