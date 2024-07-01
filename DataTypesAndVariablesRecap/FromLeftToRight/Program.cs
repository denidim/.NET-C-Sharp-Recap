namespace FromLeftToRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] intArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                long sum = 0;

                var leftSum = intArr[0];
                var rightSum = intArr[1];
                var biggerNum = Math.Max(leftSum, rightSum);

                while (biggerNum != 0)
                {
                    sum += biggerNum % 10;
                    biggerNum /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}