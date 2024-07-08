namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            string[] names = Console.ReadLine()!.Split();

            Func<string, int, bool> condition = (name, sum) => name.Sum(x => x) >= sum;

            Func<string[], int, Func<string, int, bool>, string> func = (names, n, condition)
                => names.Where(x => condition(x, n)).FirstOrDefault()!;

            string name = func(names,n,condition);

            Console.WriteLine(name);
        }
    }
}
