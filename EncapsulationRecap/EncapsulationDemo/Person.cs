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

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if(salary < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

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
