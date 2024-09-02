namespace Vehicles
{
    internal class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double IncreaseConsumption => 1.6 + FuelConsumption;

        public override string Drive(double distance)
        {
            string result = string.Empty;

            var consumption = IncreaseConsumption * distance;

            if (FuelQuantity > consumption)
            {
                FuelQuantity -= consumption;

                result = $"Truck travelled {distance} km";
            }
            else
            {
                result = $"Truck needs refueling";
            }

            return result;
        }

        public override void Refuel(double amount)
        {
            FuelQuantity += amount * 0.95; // FuelQuantity = (FuelQuantity + amount) * 0.95;
        }
    }
}
