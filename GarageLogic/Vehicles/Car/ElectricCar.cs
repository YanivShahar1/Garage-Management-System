using GarageLogic.Energy;
using GarageLogic.Info;
namespace GarageLogic.Vehicles
{
    public class ElectricCar : Car
    {
        public const float MaxBatteryCapacityKWh = 5.2f;

        public ElectricCar()
        {
            this.EnergySystem = new ElectricEnergySystem(MaxBatteryCapacityKWh);
        }
    }
}
