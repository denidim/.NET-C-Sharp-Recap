using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClassPerson
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int Age { get => age; set => age = value; }
    }
}
