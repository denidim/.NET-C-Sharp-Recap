namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> productShop =
                new Dictionary<string, Dictionary<string, double>>();

            string input;

            while ((input = Console.ReadLine()!) != "Revision")
            {
                string[] strings = input.Split(", ");
                string shop = strings[0];
                string product = strings[1];
                double price = double.Parse(strings[2]);

                if (!productShop.ContainsKey(shop))
                {
                    productShop.Add(shop, new Dictionary<string, double> { });
                }
                productShop[shop].Add(product, price);
            }
            foreach (var item in productShop.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var shopProduct in item.Value)
                {
                    Console.WriteLine($"Product: {shopProduct.Key}, Price: {shopProduct.Value}");
                }
            }
        }
    }
}
