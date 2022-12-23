using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        private double _fuelQuantity;
        private double _fuelConsumption;


        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }


        public double FuelQuantity
        {
            get
            {
                return this._fuelQuantity;
            }
            private set
            {
                this._fuelQuantity = value;
            }
        }

        public double FuelConsumption
        { 
            get
            {
                return this._fuelConsumption;
            }
            protected set 
            { 
                this._fuelConsumption = value;
            } 
        }

        public string Drive(double distance)
        {
            double fuelNeeded = this._fuelConsumption * distance;

            if (fuelNeeded <= FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }

        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
