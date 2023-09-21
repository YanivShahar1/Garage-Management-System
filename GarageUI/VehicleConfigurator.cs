using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GarageLogic;
using GarageLogic.Vehicles;
using GarageLogic.Info;
using GarageLogic.Enums;

namespace GarageUI
{
    public class VehicleConfigurator
    {
        private VehicleBuilder _builder;
        private AddVehicleForm _addVehicleForm;
        public VehicleConfigurator(AddVehicleForm addVehicleForm ,VehicleBuilder builder)
        {
            _builder = builder;
            _addVehicleForm = addVehicleForm;
        }

        public void ConfigureVehicle()
        {
            _builder.WithVehicleInfo(GetVehicleInfo());

            if (_builder.Vehicle is Car)
            {
                ConfigureCar();
            }
            else if (_builder.Vehicle is Motorcycle)
            {
                ConfigureMotorcycle();
            }
            else if (_builder.Vehicle is Truck)
            {
                ConfigureTruck();
            }
        }

        private VehicleInfo GetVehicleInfo()
        {
            string model = _addVehicleForm.GetModelName();
            int year = _addVehicleForm.GetVehicleYear();
            string licenseNumber = _addVehicleForm.GetLicenseNumber();
            return new VehicleInfo(model, year, licenseNumber);
        }

       

        private void ConfigureCar()
        {
            CarBuilder carBuilder = (CarBuilder)_builder;
            carBuilder.WithColor(_addVehicleForm.GetSelectedCarColor())
                       .WithNumberOfDoors(_addVehicleForm.GetSelectedNumberOfDoors());
        }

        private void ConfigureMotorcycle()
        {
            MotorcycleBuilder motorcycleBuilder = (MotorcycleBuilder)_builder;
            motorcycleBuilder.WithLicenseType(_addVehicleForm.GetSelectedLicenseType());
        }

        private void ConfigureTruck()
        {
            TruckBuilder truckBuilder = (TruckBuilder)_builder;
            truckBuilder.WithCargoVolume(_addVehicleForm.GetCargoVolume());
        }

        // Implement methods to get user selections from UI controls, e.g., GetSelectedCarColor, GetSelectedNumberOfDoors, etc.
    }

}
