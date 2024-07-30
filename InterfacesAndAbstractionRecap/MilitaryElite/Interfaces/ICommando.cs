namespace MilitaryElite.Interfaces
{
    internal interface ICommando
    {
        ICollection<IMission> Missions { get; }
    }
}
