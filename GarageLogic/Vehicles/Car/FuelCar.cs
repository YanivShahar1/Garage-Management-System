using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class FuelCar : Car
    {
        private const FuelEnergySystem.eFuelType defaultFuelType = FuelEnergySystem.eFuelType.Octan95;
        private const float defaultMaxFuelCapacity = 46.0f;

        public FuelCar(VehicleInfo vehicleInfo, eColor color, eNumberOfDoors numberOfDoors)
            : base(
                  vehicleInfo,
                  new FuelEnergySystem(defaultMaxFuelCapacity,defaultFuelType),
                  color,
                  numberOfDoors)
        {
        }
    }
}
