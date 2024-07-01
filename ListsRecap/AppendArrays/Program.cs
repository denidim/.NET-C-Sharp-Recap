namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();

            List<int> result = new List<int>();

            for (int i = list.Count-1; i >= 0; i--)
            {
                var intArray = list[i]
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                result.AddRange(intArray);
            }

            Console.WriteLine(string.Join(' ',result));
        }
    }
}