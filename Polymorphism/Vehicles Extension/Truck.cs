using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private const double _airConditioning = 1.6;
        private const double _refuelCoefficient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + _airConditioning, tankCapacity)
        {

            
        }


        public override void Refuel(double liters)
        {
            if (liters > TankCapacity - FuelQuantity)
            {
                base.Refuel(liters);
            }
            else
            {
                base.Refuel(liters * _refuelCoefficient);
            }
        }

    }
}
