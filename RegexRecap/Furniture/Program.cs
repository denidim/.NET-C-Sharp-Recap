using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            Dictionary<string, double> products = new();

            while (true)
            {
                string input = Console.ReadLine()!;

                if (input == "Purchase")
                {
                    break;
                }

                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    products[name] = price*quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            products.ToList()
                .ForEach(p => Console.WriteLine($"{p.Key}"));

            Console.WriteLine($"Total money spend: {products.Sum(x => x.Value):f2}");
        }
    }
}
