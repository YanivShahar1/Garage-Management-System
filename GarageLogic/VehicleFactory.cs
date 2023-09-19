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
        public static Vehicle CreateVehicle(eVehicleType vehicleType, VehicleInfo vehicleInfo)
        {
            Vehicle createdVehicle;

            switch (vehicleType)
            {
                case eVehicleType.FuelCar:
                    createdVehicle = new FuelCar(vehicleInfo);
                    break;

                case eVehicleType.ElectricCar:
                    createdVehicle = new ElectricCar(vehicleInfo);
                    break;

                case eVehicleType.FuelMotorcycle:
                    createdVehicle = new FuelMotorcycle(vehicleInfo);
                    break;

                case eVehicleType.ElectricMotorcycle:
                    createdVehicle = new ElectricMotorcycle(vehicleInfo); 
                    break;

                case eVehicleType.FuelTruck:
                    createdVehicle = new FuelTruck(vehicleInfo); 
                    break;

                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }

            return createdVehicle;
        }

