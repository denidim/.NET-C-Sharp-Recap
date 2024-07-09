using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCarPark
{
    internal class Car
    {
        public Car(string make, string model, int horsePower, string registrationNUmber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNUmber;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Make: {this.Make}");
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"HorsePower: {this.HorsePower}");
            stringBuilder.AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
