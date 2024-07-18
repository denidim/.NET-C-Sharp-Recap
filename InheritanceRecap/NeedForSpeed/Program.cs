namespace NeedForSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new RaceMotorcycle(100, 200);

            vehicle.Drive(2);
        }
    }
}
