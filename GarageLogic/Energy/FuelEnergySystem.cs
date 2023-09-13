using System;

namespace GarageLogic.Energy
{
    public class FuelEnergySystem : IEnergySystem
    {
        public void SupplyEnergy()
        {
            Console.WriteLine("Supplying fuel energy...");
        }
    }
}
