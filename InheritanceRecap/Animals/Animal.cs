using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private int age;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public string Gender { get; set; }

        public abstract void ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");

            return sb.ToString().TrimEnd();
        }
    }
}