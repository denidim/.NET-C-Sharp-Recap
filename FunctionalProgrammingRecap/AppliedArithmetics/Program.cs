namespace AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            string action = Console.ReadLine()!;

            Action<int[]> addNumber = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] += 1;
                }
            };

            Func<int[], int[]> multiply = x => x.Select(x => x *= 2).ToArray();

            Func<int[], int[]> subtract = x => x.Select(x => x -= 1).ToArray();

            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            while (action != "end")
            {
                if (action == "add")
                {
                    addNumber(numbers);
                }
                else if (action == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (action == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (action == "print")
                {
                    print(numbers);
                }
                action = Console.ReadLine()!;
            }
        }
    }
}
