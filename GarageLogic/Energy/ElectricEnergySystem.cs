using System;

namespace GarageLogic.Energy
{
    public class ElectricEnergySystem : EnergySystem
    {
        internal ElectricEnergySystem(float maxBattery) : base(maxBattery) { }
        public void Charge(float amount)
        {
            if (CurrentEnergy + amount > MaxEnergyCapacity)
            {
                throw new InvalidOperationException("Cannot overcharge the battery.");
            }
            CurrentEnergy += amount;
        }
    }
}
