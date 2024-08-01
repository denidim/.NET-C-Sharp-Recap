namespace MilitaryElite.Models
{
    using Interfaces;
    using Enums;
    using System.Collections.Generic;
    using System.Text;

    internal class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs = new List<IRepair>();

        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corp)
        {
            this.repairs = repairs.ToList();
        }

        public ICollection<IRepair> Repairs => repairs.AsReadOnly();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine("Repairs:");

            sb.Append($"  {string.Join($"{Environment.NewLine}  ", this.Repairs)}");

            return sb.ToString();
        }
    }
}
