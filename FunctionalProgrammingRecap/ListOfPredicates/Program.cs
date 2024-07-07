namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            List<int> numbersInRange = Enumerable
                .Range(1, n)
                .ToList();

            int[] divNumbers = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
