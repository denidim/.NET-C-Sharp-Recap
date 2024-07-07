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

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (int divisor in divNumbers)
            {
                predicates.Add(x => x % divisor == 0);
            }
        }
    }
}
