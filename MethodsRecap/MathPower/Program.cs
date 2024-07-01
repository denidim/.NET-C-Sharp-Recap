namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double result = CalculatePower(n, p);
            Console.WriteLine(result);
        }

        private static double CalculatePower(double n, int p)
        {
            return Math.Pow(n, p);
        }
    }
}