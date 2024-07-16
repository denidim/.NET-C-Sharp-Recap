namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //even -> odds -> asc -> func

            Func<int, int, int> customComparer = (x, y) =>
            {
                return (x % 2 == 0) && (y % 2 != 0)
                ? -1
                : (x % 2 != 0) && (y % 2 == 0)
                ? 1
                : x > y
                ? 1
                : x < y
                ? -1
                : 0;
            };
            Array.Sort(ints, (x, y) => customComparer(x, y));

            Console.WriteLine(string.Join(", ", ints));
        }
    }
}
