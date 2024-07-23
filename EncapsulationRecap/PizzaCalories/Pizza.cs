namespace PizzaCalories
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough { get => dough; private set => dough = value; }

        public IReadOnlyCollection<Topping> Toppings => this.toppings.AsReadOnly();

        public double CalculateCalories => this.Dough.Calories + toppings.Sum(x => x.Calories);

        public void Add(Topping topping)
        {
            ArgumentNullException.ThrowIfNull(topping);

            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }
    }
}
