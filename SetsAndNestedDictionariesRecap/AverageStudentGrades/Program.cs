namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            Dictionary<string, List<decimal>> keyValuePairs = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();

                if (!keyValuePairs.ContainsKey(input[0]))
                {
                    keyValuePairs.Add(input[0], new List<decimal>());
                }
                keyValuePairs[input[0]].Add(decimal.Parse(input[1]));

            }
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value):f2} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
