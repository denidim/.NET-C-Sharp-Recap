namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int tankCapacity = 255;
            int waterLevel = 0;

            for (int i = 0; i < lines; i++)
            {
                int incomingWater = int.Parse(Console.ReadLine());

                if (waterLevel + incomingWater <= tankCapacity)
                {
                    waterLevel += incomingWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(waterLevel);
        }
    }
}