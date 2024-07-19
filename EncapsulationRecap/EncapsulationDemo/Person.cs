namespace EncapsulationDemo
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public decimal Salary { get => salary; set => salary = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public int Age { get => age; set => age = value; }

        public void IncreaseSalary(decimal percentage)
        {
            if(this.age < 30)
            {
                percentage *= 0.5m;
            }

            this.salary += this.salary * percentage / 100;
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary} leva.";
        }
    }
}
