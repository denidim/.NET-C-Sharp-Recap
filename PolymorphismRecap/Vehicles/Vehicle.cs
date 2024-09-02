namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }
        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; } // liters per km

        public abstract double IncreaseConsumption { get; }

        public abstract string Drive(double distance);

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }
    }
}
