using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    internal class Private : Soldier, IPrivate
    {
        private decimal salary;

        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get => salary; private set => salary = value; }
    }
}
