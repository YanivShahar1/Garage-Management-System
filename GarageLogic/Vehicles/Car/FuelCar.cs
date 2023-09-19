using GarageLogic.Energy;
using GarageLogic.Info;
namespace GarageLogic.Vehicles
{
    public class FuelCar : Car
    {
        private const FuelEnergySystem.eFuelType defaultFuelType = FuelEnergySystem.eFuelType.Octan95;
        private const float defaultMaxFuelCapacity = 46.0f;

        public FuelCar(VehicleInfo vehicleInfo, eColor color = eColor.Blue , eNumberOfDoors numberOfDoors = eNumberOfDoors.Four)
            : base(
                  vehicleInfo,
                  color,
                  numberOfDoors)
        {
            this.EnergySystem = new FuelEnergySystem(defaultMaxFuelCapacity, defaultFuelType);
        }
    }
}
