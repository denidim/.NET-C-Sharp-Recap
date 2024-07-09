using System.Text;

namespace CarSalesman
{
    internal class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int? displacement)
            :this (model,power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, int? displacement, string? efficiency)
            : this(model, power, displacement)
        {
            Efficiency = efficiency;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int? Displacement { get; set; }

        public string? Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {Displacement}");
            sb.AppendLine($"    Efficiency: {Efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
