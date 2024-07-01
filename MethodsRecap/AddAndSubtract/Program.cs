namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //int sum = Sum(a, b);
            int result = Subtract(Sum(a, b), c);

            Console.WriteLine(result);
        }

        private static int Subtract(int v, int c)
        {
            return v - c;
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}