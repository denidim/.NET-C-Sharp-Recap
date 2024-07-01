namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallestNumber(a, b, c);
        }

        private static void PrintSmallestNumber(int a, int b, int c)
        {
            int[] intArray = new int[] { a, b, c };

            int smallest = int.MaxValue;

            foreach (var item in intArray)
            {
                if (item < smallest)
                {
                    smallest = item;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}