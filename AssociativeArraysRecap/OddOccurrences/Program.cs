namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()!.Split().Select(x=>x.ToLower()).ToArray();

            Dictionary<string,int> keyValuePairs = new();

            foreach (string word in words)
            {
                if (!keyValuePairs.ContainsKey(word))
                {
                    keyValuePairs.Add(word, 1);
                }
                else
                {
                    keyValuePairs[word]++;
                }
            }

            foreach (var pair in keyValuePairs)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}
