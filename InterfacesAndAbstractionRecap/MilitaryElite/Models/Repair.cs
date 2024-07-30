namespace MilitaryElite.Models
{
    using Interfaces;

    internal class Repair : IRepair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get => partName; private set => partName = value; }

        public int HoursWorked { get => hoursWorked; private set => hoursWorked = value; }
    }
}
