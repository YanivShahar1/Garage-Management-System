﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GarageLogic.Energy;

namespace GarageLogic
{
    public abstract class Vehicle
    {
        private IEnergySystem energySystem;

        protected Vehicle(IEnergySystem energySystem)
        {
            this.energySystem = energySystem;
        }

    }
}
