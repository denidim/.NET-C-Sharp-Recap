namespace FootballTeamGenerator
{
    internal class Team
    {
        private List<Player> players;

        private string name;

        public Team(string name)
        {
            Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(name)} should not be empty.");
                }
                name = value;
            }
        }

        public double Stats => players.Count > 0 ? Math.Ceiling(this.players.Average(x => x.SkillLevel())) : 0;

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public bool RemovePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name)!;

            return this.players.Remove(player!);
        }
    }
}
