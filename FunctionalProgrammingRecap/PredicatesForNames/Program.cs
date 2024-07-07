namespace PredicatesForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            List<string> names = Console.ReadLine()!.Split().ToList();


            Func<string, int, bool> isLessOrEqual = (name, length) => name.Length <= length;

            string[] result = names.Where(x => isLessOrEqual(x,n)).ToArray();

            Console.WriteLine(string.Join("",result));

            //Predicate<string> lessThanOrEqual = x => x.Length <= n;

            //Action<List<string>> action = x => Console.Write(string.Join(" ", x.Where(x => lessThanOrEqual(x))));

            //action(names);
        }
    }
}
