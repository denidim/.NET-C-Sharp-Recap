namespace MilitaryElite.Models
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    internal class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privates = new List<IPrivate>();

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates)
            : base(id, firstName, lastName, salary)
        {
            this.privates = privates.ToList();
        }

        public ICollection<IPrivate> Privates => this.privates.AsReadOnly();


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine("Privates:");

            sb.Append($"  {string.Join($"{Environment.NewLine}  ", this.privates)}");

            return sb.ToString();
        }
    }
}
