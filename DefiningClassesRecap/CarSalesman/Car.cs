using System.Text;

namespace CarSalesman
{
    internal class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int? weight) : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, int? weight, string? color) : this(model, engine, weight)
        {
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int? Weight { get; set; }

        public string? Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"{Engine}:");
            sb.AppendLine($" Weight: {Weight}:");
            sb.AppendLine($" Color: {Color}:");

            return sb.ToString().TrimEnd();
        }
    }
}
