using System;

namespace GarageLogic.Vehicles
{
    public class Wheel
    {
        public float CurrentAirPressure { get; private set; }
        public float MaxAirPressure { get; }
        
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
