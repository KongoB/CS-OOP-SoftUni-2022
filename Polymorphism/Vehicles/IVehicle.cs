using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Vehicles
{
    public interface IVehicle
    {

        public double FuelQuantity { get; }
        public double FuelConsumption { get; }

        public void Refuel(double liters);

        public string Drive(double distance);

    }
}
