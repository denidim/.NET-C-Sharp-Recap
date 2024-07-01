namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = Divide(Factorial(a), Factorial(b));

            Console.WriteLine($"{result:f2}");
        }

        private static double Divide(double first, double second)
        {
            return first / second ;
        }

        private static double Factorial(double n)
        {
            if(n == 0)
            {
                return 1;
            }

            return n*Factorial(n-1);
        }
    }
}