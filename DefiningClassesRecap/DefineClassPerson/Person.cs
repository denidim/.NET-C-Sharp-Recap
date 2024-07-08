﻿using System;
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
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            : this()
        {
            
            Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            Name = name;
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
