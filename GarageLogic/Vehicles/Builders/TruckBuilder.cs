using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Info;

namespace GarageLogic.Vehicles
{
    public class TruckBuilder : VehicleBuilder
    {
        private Truck Truck => (Truck)Vehicle;

        public TruckBuilder(Truck truck) : base(truck)
        {
        }

        public override VehicleBuilder WithVehicleInfo(VehicleInfo vehicleInfo)
        {
            Truck.Info = vehicleInfo;
            return this;
        }

        public TruckBuilder WithCargoVolume(float cargoVolume)
        {
            Truck.CargoVolume = cargoVolume;
            return this;
        }
        public TruckBuilder WithDangerousSubstances(bool isContainsDangerousSubstances)
        {
            Truck.ContainsDangerousSubstances = isContainsDangerousSubstances;
            return this;
        }
        public override Vehicle Build()
        {
            return Truck;
        }
    }
}
