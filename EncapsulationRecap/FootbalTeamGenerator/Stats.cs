namespace FootballTeamGenerator
{
    internal abstract class Stats
    {
        private const int MinStats = 0;

        private const int MaxStats = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                ValidateSkill(value, nameof(Endurance));
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                ValidateSkill(value, nameof(Sprint));
                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                ValidateSkill(value, nameof(Dribble));
                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                ValidateSkill(value, nameof(Passing));
                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                ValidateSkill(value, nameof(Shooting));
                shooting = value;
            }
        }
        public abstract double SkillLevel();

        private static void ValidateSkill(int value, string skillName)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{skillName} must be between {MinStats} and {MaxStats}.");
            }
        }
    }
}