using System;

namespace GarageLogic.Energy
{
    public class ElectricEnergySystem : IEnergySystem
    {
        public void SupplyEnergy()
        {
            Console.WriteLine("Supplying electric energy...");
        }
    }
}
