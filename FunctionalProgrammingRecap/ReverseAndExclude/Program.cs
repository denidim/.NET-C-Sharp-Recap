namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine()!);

            Predicate<int> isDivisible = x => x % n == 0;

            Func<List<int>, List<int>> removeFunction = x => x.Where(x => !isDivisible(x)).ToList();

            List<int> result = removeFunction(collection);

            Action<List<int>> reverseAction = x => x.Reverse();

            reverseAction(result);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
