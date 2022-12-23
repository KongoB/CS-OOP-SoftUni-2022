using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private const double _airConditioning = 1.6;
        private const double _refuelCoefficient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + _airConditioning)
        {

            
        }


        public override void Refuel(double liters)
        {
            base.Refuel(liters * _refuelCoefficient);
        }

    }
}
