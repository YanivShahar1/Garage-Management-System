using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageLogic.Vehicles
{
    public class Wheel
    {
        public string Manufacturer { get; private set; } = "Unknown";
        public float CurrentAirPressure { get; private set; }
        public float MaxAirPressure { get; }

        public void SetManufacturer(string manufacturer)
        {
            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                throw new ArgumentException("Manufacturer name cannot be null or empty.");
            }

            Manufacturer = manufacturer;
        }
        public Wheel(float maxAirPressure)
        {
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


}
