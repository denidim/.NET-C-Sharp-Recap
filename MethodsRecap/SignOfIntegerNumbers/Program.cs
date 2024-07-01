namespace SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            IntegerCheck(n);

        }

        private static void IntegerCheck(int v)
        {
            if (v == 0)
            {
                Console.WriteLine($"The number {v} is zero.");

            }
            else if(v > 0)
            {
                Console.WriteLine($"The number {v} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {v} is negative.");
            }
        }
    }
}