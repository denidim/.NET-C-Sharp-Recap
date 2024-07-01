namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

            SortedDictionary<double,int> keyValuePairs = new();

            foreach (var num in numbers)
            {
                if (keyValuePairs.ContainsKey(num))
                {
                    keyValuePairs[num]++;
                }
                else
                {
                    keyValuePairs[num] = 1;
                }
            }

            foreach (var key in keyValuePairs.Keys)
            {
                Console.WriteLine($"{key} -> {keyValuePairs[key]}");
            }
        }
    }
}
