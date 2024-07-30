namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;

    internal abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp)
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public SoldierCorpEnum Corp { get; }
    }
}
