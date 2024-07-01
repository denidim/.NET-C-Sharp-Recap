namespace CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

            Dictionary<double,int> keyValuePairs = new Dictionary<double,int>();

            foreach (var keyValue in doubles)
            {
                if (!keyValuePairs.ContainsKey(keyValue))
                {
                    keyValuePairs.Add(keyValue, 0);
                }
                keyValuePairs[keyValue] +=1;
            }

            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value} times");
            }
        }
    }
}
