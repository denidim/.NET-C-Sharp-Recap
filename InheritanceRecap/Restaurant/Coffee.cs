namespace Restaurant
{
    internal class Coffee : HotBeverage
    {
        private const double DefaultCoffeeMilliliters = 50;

        private const decimal DefaultCoffeePrice = 3.50m;

        public Coffee(string name, double caffeine = 0) : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
