namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()!);

            Dictionary<string, List<string>> synonyms = new();

            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine()!;
                string synonym = Console.ReadLine()!;

                if (synonyms.TryGetValue(word, out List<string>? value))
                {
                    value.Add(synonym);
                }
                else
                {
                    synonyms.Add(word, new List<string> { synonym });
                }
            }
            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
