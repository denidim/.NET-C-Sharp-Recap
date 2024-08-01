namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    internal class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions = new List<IMission>();

        public Commando(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IMission> missions)
            : base(id, firstName, lastName, salary, corp)
        {
            this.missions = missions.ToList();
        }

        public ICollection<IMission> Missions => missions.AsReadOnly();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());


            if (this.Missions.Count != 0)
            {
                sb.AppendLine($"Missions:");
                sb.Append($"  {string.Join($"{Environment.NewLine}  ", this.Missions)}");
            }
            else
            {
                sb.Append("Missions:");
            }

            return sb.ToString();
        }
    }
}
