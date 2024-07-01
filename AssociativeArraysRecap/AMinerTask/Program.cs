namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = new();
            string input = Console.ReadLine()!;
            while (input != "stop")
            {

                int quantity = int.Parse(Console.ReadLine()!);

                if (!keyValuePairs.ContainsKey(input))
                {
                    keyValuePairs[input] = 0;
                }

                keyValuePairs[input] += quantity;

                input = Console.ReadLine()!;
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
