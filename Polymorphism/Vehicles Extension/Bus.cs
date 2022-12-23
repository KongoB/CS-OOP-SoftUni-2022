
namespace Vehicles
{
    public class Bus : Vehicle
    {

        private const double _airConditioning = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive (double distance)
        {
            double fuelNeeded = (this.FuelConsumption + _airConditioning) * distance;

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

        public string DriveEmpty(double distance)
        {
            double fuelNeeded = this.FuelConsumption * distance;

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

    }
}
