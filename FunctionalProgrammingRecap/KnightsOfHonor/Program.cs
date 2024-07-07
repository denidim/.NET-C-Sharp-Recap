namespace KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printAndAppendNames = x => Console.WriteLine("Sir " + string.Join($"{Environment.NewLine}Sir ", x));

            string[] names = Console.ReadLine()!.Split();

            printAndAppendNames.Invoke(names);
        }
    }
}
