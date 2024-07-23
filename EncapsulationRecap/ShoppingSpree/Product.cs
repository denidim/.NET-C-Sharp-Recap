namespace ShoppingSpree
{
    internal class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), $"{nameof(Name)} Cannot be empty");
                }
                name = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(value), $"{nameof(Cost)} Cannot be negative");
                }
                cost = value;
            }
        }
    }
}
