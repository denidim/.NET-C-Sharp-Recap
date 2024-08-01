namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;
    using System.Text;

    internal abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp)
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public SoldierCorpEnum Corp { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($"Corps: {this.Corp}");

            return sb.ToString().TrimEnd();
        }
    }
}
