namespace FootballTeamGenerator
{
    internal class Player : Stats
    {
        private string name;

        public Player(string name, params int[] stats)
            : base(stats[0], stats[1], stats[2], stats[3], stats[4])
        {
            Name = name;
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

        public override double SkillLevel()
        {
            double all = base.Endurance + base.Dribble + base.Sprint + base.Passing + base.Shooting;

            int countOfPlayerSkills = 5;

            return all / countOfPlayerSkills;
        }
    }
}
