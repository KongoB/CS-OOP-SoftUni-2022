using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        private double _fuelQuantity;
        private double _fuelConsumption;
        private double _tankCapacity;


        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }


        public double FuelQuantity
        {
            get
            {
                return this._fuelQuantity;
            }
            protected set
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

        public double TankCapacity 
        {
            get
            {
                return this._tankCapacity;
            }
            protected set
            {
                if (value < _fuelQuantity)
                {
                    this._fuelQuantity = 0;
                    this._tankCapacity = value;
                }
                else
                {
                    this._tankCapacity = value;
                }
            }
        }



        public virtual string Drive(double distance)
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
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (TankCapacity - FuelQuantity < liters)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
