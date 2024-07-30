namespace MilitaryElite.Interfaces
{
    internal interface IEngineer
    {
        ICollection<IRepair> Repairs { get; }
    }
}
