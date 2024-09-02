namespace Vehicles
{
    internal class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double IncreaseConsumption => 0.9 + FuelConsumption;

        public override string Drive(double distance)
        {
            string result = string.Empty;

            var consumption = IncreaseConsumption * distance;

            if (FuelQuantity > consumption)
            {
                FuelQuantity -= consumption;

                result = $"Car travelled {distance} km";
            }
            else
            {
                result = $"Car needs refueling";
            }

            return result;
        }
    }
}
