namespace StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Dictionary<string, List<double>> keyValuePairs = new();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine()!;
                double grade = double.Parse(Console.ReadLine()!);

                if(keyValuePairs.TryGetValue(name, out List<double>? value))
                {
                    value.Add(grade);
                }
                else
                {
                    keyValuePairs[name] = new List<double>();
                    keyValuePairs[name].Add(grade);
                }
            }
            keyValuePairs.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToList()
                .ForEach(x => 
                {
                    Console.WriteLine($"{x.Key} -> {x.Value.Average():f2}");
                });
        }
    }
}
