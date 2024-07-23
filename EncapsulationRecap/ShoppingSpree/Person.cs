namespace ShoppingSpree
{
    internal class Person
    {

        private string name;
        private decimal money;
        private List<Product> bagOfProduct;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(value), $"{nameof(Name)} Cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(value), $"{nameof(Money)} Cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> BagOfProduct { get => bagOfProduct; set => bagOfProduct = value; }
    }
}
