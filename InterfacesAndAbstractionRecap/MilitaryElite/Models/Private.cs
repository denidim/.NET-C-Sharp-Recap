﻿namespace MilitaryElite.Models
{
    using Interfaces;

    internal class Private : Soldier, IPrivate
    {
        private decimal salary;

        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get => salary; private set => salary = value; }

        public override string ToString()
        {
            return $"{base.ToString() + "Salary: " + string.Format("{0:0.00}", this.Salary)}";
        }
    }
}
