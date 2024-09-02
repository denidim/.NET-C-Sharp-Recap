namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "Drive")
                {
                    double distance = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else
                {
                    double liters = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        car.Refuel(liters);
                    }
                    else
                    {
                        truck.Refuel(liters);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {Math.Round(truck.FuelQuantity, 2, MidpointRounding.AwayFromZero)}");
        }
    }
}
