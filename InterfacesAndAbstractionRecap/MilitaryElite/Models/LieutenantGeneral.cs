namespace MilitaryElite.Models
{
    using Interfaces;
    using System.Collections.Generic;

    internal class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privates = new List<IPrivate>();

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates)
            : base(id, firstName, lastName, salary)
        {
            this.privates = privates.ToList();
        }

        public ICollection<IPrivate> Privates => this.privates.AsReadOnly();

    }
}
