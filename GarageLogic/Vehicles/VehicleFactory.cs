using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Vehicles;
using GarageLogic.Info;
using GarageLogic.Enums;

namespace GarageLogic
{
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(eVehicleType vehicleType)
        {
            Vehicle selectedVehicle;
            switch (vehicleType)
            {
                case eVehicleType.FuelCar:
                    selectedVehicle = new FuelCar();
                    break;
                case eVehicleType.ElectricCar:
                    selectedVehicle = new ElectricCar();
                    break;
                case eVehicleType.FuelMotorcycle:
                    selectedVehicle = new FuelMotorcycle();
                    break;
                case eVehicleType.ElectricMotorcycle:
                    selectedVehicle = new ElectricMotorcycle();
                    break;
                case eVehicleType.FuelTruck:
                    selectedVehicle = new FuelTruck();
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
            return selectedVehicle;
        }

        public static VehicleBuilder CreateBuilder(eVehicleType vehicleType, Vehicle vehicle)
        {
            switch (vehicleType)
            {
                case eVehicleType.FuelCar:
                case eVehicleType.ElectricCar:
                    return new CarBuilder((Car)vehicle);

                case eVehicleType.FuelTruck:
                    return new TruckBuilder((Truck)vehicle);

                case eVehicleType.FuelMotorcycle:
                case eVehicleType.ElectricMotorcycle:

                    return new MotorcycleBuilder((Motorcycle)vehicle);

                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }

}

