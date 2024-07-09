namespace CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesOfEngines = int.Parse(Console.ReadLine()!);

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < linesOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine()!.Split();

                string model =  engineInfo[0];

                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine(model, power);

                if (engineInfo.Length == 3)
                {
                    engine.Displacement = int.Parse(engineInfo[2]);
                }
                if(engineInfo.Length == 4)
                {
                    engine.Efficiency = engineInfo[3];
                }
                engines.Add(engine);
            }

            int linesOfCars = int.Parse(Console.ReadLine()!);

            List<Car> cars = new List<Car>();

            for (int i = 0; i < linesOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()!.Split();

                string model = carInfo[0];

                string engineModel = carInfo[1];

                Engine engine = engines.Where(x=>x.Model == engineModel).FirstOrDefault()!;

                Car car = new Car(model, engine);

                if(carInfo.Length == 3)
                {
                    car.Weight = int.Parse(carInfo[2]);
                }
                if (carInfo.Length == 4)
                {
                    car.Color = Console.ReadLine();
                }
                cars.Add(car);
            }
        }
    }
}
