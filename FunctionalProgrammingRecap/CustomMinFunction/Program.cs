namespace CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = x => x.Min();

            int[] nums = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

            Console.WriteLine(func(nums));
        }
    }
}
