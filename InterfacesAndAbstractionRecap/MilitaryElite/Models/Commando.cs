namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;
    using System.Collections.Generic;

    internal class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions = new List<IMission>();

        public Commando(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IMission> missions)
            : base(id, firstName, lastName, salary, corp)
        {
            this.missions = missions.ToList();
        }

        public ICollection<IMission> Missions => missions.AsReadOnly();
    }
}
