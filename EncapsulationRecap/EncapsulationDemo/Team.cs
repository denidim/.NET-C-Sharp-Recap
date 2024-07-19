namespace EncapsulationDemo
{
    internal class Team
    {
        private string name;

        private List<Person> firstTeam = new List<Person>();

        private List<Person> reserveTeam = new List<Person>();

        public Team(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }

         IReadOnlyCollection<Person> FirstTeam { get => firstTeam.AsReadOnly(); }

        public IReadOnlyCollection<Person> ReserveTeam { get => reserveTeam.AsReadOnly(); }

        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                firstTeam.Add(person);
            }

            reserveTeam.Add(person);
        }

        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players.\r\nReserve team has {reserveTeam.Count} players.";
        }
    }
}
