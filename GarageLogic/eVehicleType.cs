using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageLogic
{
    public enum eVehicleType
    {
        [EnumExtensions.DisplayName("Fuel Car")]
        FuelCar,

        [EnumExtensions.DisplayName("Electric Car")]
        ElectricCar,

        [EnumExtensions.DisplayName("Fuel Motorcycle")]
        FuelMotorcycle,

        [EnumExtensions.DisplayName("Electric Motorcycle")]
        ElectricMotorcycle,

        [EnumExtensions.DisplayName("Fuel Truck")]
        FuelTruck
    }


}
