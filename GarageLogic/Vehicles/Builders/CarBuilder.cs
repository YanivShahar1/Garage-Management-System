using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public class CarBuilder : VehicleBuilder
    {
        private Car Car => (Car)Vehicle;

        public CarBuilder(Car car) : base(car) { }

        public override VehicleBuilder WithVehicleInfo(VehicleInfo vehicleInfo)
        {
            Car.Info = vehicleInfo;
            return this;
        }

        public CarBuilder WithColor(Car.eColor color)
        {
            Car.Color = color;
            return this;
        }

        public CarBuilder WithNumberOfDoors(Car.eNumberOfDoors doors)
        {
            Car.NumberOfDoors = doors;
            return this;
        }
        public override Vehicle Build()
        {
            return Car;
        }

    }
}
