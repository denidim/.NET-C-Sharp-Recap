namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Dictionary<string, string> keyValuePairs = new();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine()!;
                string command = input.Split(' ')[0];
                string name = input.Split(' ')[1];

                if (command == "register")
                {
                    string plate = input.Split(' ')[2];

                    if (keyValuePairs.TryGetValue(name, out string? value))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {value}");
                        continue;
                    }
                    keyValuePairs[name] = plate;
                    Console.WriteLine($"{name} registered {plate} successfully");
                }
                else
                {
                    if (keyValuePairs.Remove(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        continue;
                    }
                    Console.WriteLine($"ERROR: user {name} not found");
                }
            }

            keyValuePairs.ToList().ForEach(keyValuePair =>
            {
                Console.WriteLine($"{keyValuePair.Key} => {keyValuePair.Value}");
            });
        }
    }
}
