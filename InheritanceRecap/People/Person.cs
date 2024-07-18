using System.Text;

namespace People
{
    internal class Person
    {
        private int age;

        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value, "Age cannot be negative.");

                this.age = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            return sb.ToString().TrimEnd();
        }
    }
}
