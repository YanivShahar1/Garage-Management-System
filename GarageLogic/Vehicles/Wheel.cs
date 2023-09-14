using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageLogic.Vehicles
{
    public class Wheel
    {
        public string Manufacturer { get; }
        public float CurrentAirPressure { get; private set; }
        public float MaxAirPressure { get; }

        public Wheel(string manufacturer, float maxAirPressure)
        {
            Manufacturer = manufacturer ?? throw new ArgumentNullException(nameof(manufacturer), "Manufacturer cannot be null.");
            MaxAirPressure = maxAirPressure;
            CurrentAirPressure = 0;
        }

        public void Inflate(float amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Inflation amount cannot be negative.", nameof(amount));
            }

            if (CurrentAirPressure + amount <= MaxAirPressure)
            {
                CurrentAirPressure += amount;
            }
            else
            {
                throw new InvalidOperationException("Cannot inflate beyond the maximum air pressure.");
            }
        }
    }

    public abstract class Vehicle
    {
        // Common properties for all vehicles.
        public List<Wheel> Wheels { get; }

        protected Vehicle()
        {
            Wheels = new List<Wheel>();
        }

        // Other common properties and methods.
    }

    // Define other vehicle classes (Car, Motorcycle, Truck) and their specific properties/methods.


}
