using System;

namespace GarageLogic.Energy
{
    public class FuelEnergySystem : EnergySystem
    {
        public enum eFuelType
        {
            Octan98,
            Octan95,
            Soler
        }
        public eFuelType TypeOfFuel { get; }
        public FuelEnergySystem(float maxFuel, eFuelType fuelType) : base(maxFuel)
        {
            TypeOfFuel = fuelType;
        }
        public void Refuel(float amount, eFuelType fuelType)
        {
            if (fuelType != this.TypeOfFuel)
            {
                throw new ArgumentException($"Incorrect fuel type. Expected {TypeOfFuel}, but got {fuelType}.", nameof(fuelType));
            }

            if (CurrentEnergy + amount > MaxEnergyCapacity)
            {
                throw new InvalidOperationException("Cannot overfill the fuel tank.");
            }

            CurrentEnergy += amount;
        }
    }
}
