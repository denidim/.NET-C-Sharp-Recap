namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> keyValuePairs = new();

            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "buy")
                {
                    break;//TODO
                }

                string name = input.Split(' ')[0];
                double price = double.Parse(input.Split(" ")[1]);
                double quantity = double.Parse(input.Split(' ')[2]);

                if (keyValuePairs.TryGetValue(name, out double[]? value))
                {
                    value[0] = price;
                    value[1] += quantity;
                }
                else
                {
                    keyValuePairs.Add(name, new double[] { price, quantity });
                }
            }

            keyValuePairs.ToList().ForEach(keyValuePair =>
            {
                double total = keyValuePair.Value[0] * keyValuePair.Value[1];
                Console.WriteLine($"{keyValuePair.Key} -> {total:f2}");
            });
        }
    }
}
