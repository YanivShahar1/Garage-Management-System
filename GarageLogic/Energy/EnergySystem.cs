
using System;

namespace GarageLogic.Energy
{
    public abstract class EnergySystem
    {
        public float CurrentEnergy { get; protected set; }
        public float MaxEnergyCapacity { get; protected set; }

        public EnergySystem(float maxEnergyCapacity)
        {
            if (maxEnergyCapacity <= 0)
            {
                throw new ArgumentException("Maximum energy capacity must be greater than 0.", nameof(maxEnergyCapacity));
            }

            MaxEnergyCapacity = maxEnergyCapacity;
            CurrentEnergy = 0; // Initialize current energy to 0.
        }
        public float EnergyPercentage()
        {
            return (CurrentEnergy / MaxEnergyCapacity) * 100;
        }
    }
}
