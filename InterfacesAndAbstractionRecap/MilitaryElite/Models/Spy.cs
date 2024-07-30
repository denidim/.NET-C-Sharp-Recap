namespace MilitaryElite.Models
{
    using Interfaces;

    internal class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get => codeNumber; private set => codeNumber = value; }
    }
}
