namespace FindEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine()!;

            //Predicate<int> isEven = x => x % 2 == 0;
            //Predicate<int> isOdd = x => x % 2 != 0;

            List<int> numbers = new List<int>();

            for (int i = ranges[0]; i < ranges[1]; i++)
            {
                numbers.Add(i);
            }

            Func<int, bool> isEven = x => x % 2 == 0;

            IEnumerable<int> result = command == "even" ?
                numbers.Where(x => isEven(x) == true) :
                numbers.Where(x => isEven(x) == false);

            //List<int> result;

            //if(command == "even")
            //{
            //    result = numbers.FindAll(isEven);
            //}
            //else
            //{
            //    result = numbers.FindAll(isOdd);
            //}

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
