using GarageLogic.Energy;

namespace GarageLogic.Vehicles
{
    public class ElectricCar : Car
    {
        private const float defaultMaxBatteryCapacity = 5.2f;

        public ElectricCar(string model, int year, string licenseNumber, eColor color, eNumberOfDoors numberOfDoors)
            : base(
                  model,
                  year,
                  licenseNumber,
                  new ElectricEnergySystem(defaultMaxBatteryCapacity),
                  color,
                  numberOfDoors)
        {
        }
    }
}
