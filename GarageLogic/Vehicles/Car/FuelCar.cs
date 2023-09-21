using GarageLogic.Energy;
using GarageLogic.Info;
namespace GarageLogic.Vehicles
{
    public class FuelCar : Car
    {
        private const FuelEnergySystem.eFuelType defaultFuelType = FuelEnergySystem.eFuelType.Octan95;
        public const float MaxFuelCapacityLiters = 46.0f;

        public FuelCar()
        {
            this.EnergySystem = new FuelEnergySystem(MaxFuelCapacityLiters, defaultFuelType);
        }
    }
}
