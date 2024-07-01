namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine()!;

            Dictionary<char, int> keyValuePairs= new();

            foreach (var ch in str.Where(x => x != ' '))
            {
                if (keyValuePairs.ContainsKey(ch))
                {
                    keyValuePairs[ch]++;
                }
                else
                {
                    keyValuePairs.Add(ch, 1);
                }
            }

            foreach (var keyValue in keyValuePairs)
            {
                Console.WriteLine($"{keyValue.Key} -> {keyValue.Value}");
            }
        }
    }
}
