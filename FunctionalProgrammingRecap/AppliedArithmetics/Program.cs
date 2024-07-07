namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            string action = Console.ReadLine()!;
        }
    }
}
