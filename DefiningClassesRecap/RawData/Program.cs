namespace RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                List<Tire> tires = new List<Tire>()
                {
                    new Tire(tire1Age,tire1Pressure),
                    new Tire(tire2Age, tire2Pressure),
                    new Tire(tire3Age, tire3Pressure),
                    new Tire(tire4Age, tire4Pressure),
                };

                Car car = new Car(model,engine,cargo,tires);

                cars.Add(car);
            }

            string commands = Console.ReadLine()!;

            List<Car> result = new List<Car>();

            if(commands == "fragile")
            {
                result = cars.FindAll(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1));
            }
            else
            {
                result = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();
            }

            foreach(Car car in result)
            {
                Console.WriteLine($"{car.Model}");
            }
        }
    }
}
