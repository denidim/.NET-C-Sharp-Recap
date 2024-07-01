namespace CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>> { };

            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }

            foreach (var continentKey in continents)
            {
                Console.WriteLine($"{continentKey.Key}:");
                foreach (var item in continentKey.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ",item.Value)}");
                }
            }
        }
    }
}
