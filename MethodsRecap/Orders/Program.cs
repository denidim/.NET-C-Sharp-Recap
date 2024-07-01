using System.Runtime.CompilerServices;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            CalculatePrice(product, quantity);
        }

        private static void CalculatePrice(string? product, decimal quantity)
        {
            decimal total = 0;

            if (product == "coffee")
            {
                total = quantity * 1.50m;
            }
            else if (product == "water")
            {
                total = quantity * 1.00m;
            }
            else if (product == "coke")
            {
                total = quantity * 1.40m;
            }
            else if (product == "snacks")
            {
                total = quantity * 2.00m;
            }
            Console.WriteLine(total);
        }
    }
}