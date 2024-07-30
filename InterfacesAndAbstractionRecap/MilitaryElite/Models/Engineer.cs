namespace MilitaryElite.Models
{
    using Interfaces;
    using Enums;
    using System.Collections.Generic;

    internal class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs = new List<IRepair>();

        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corp)
        {
            this.repairs = repairs.ToList();
        }

        public ICollection<IRepair> Repairs => repairs.AsReadOnly();
    }
}
