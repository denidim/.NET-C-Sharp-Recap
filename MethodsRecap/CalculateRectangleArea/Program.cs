namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double area = CalculateArea(width, height);
            Console.WriteLine(area);
        }

        private static double CalculateArea(int width, int height)
        {
            return (width * height);
        }
    }
}