namespace PizzaCalories
{
    internal class Dough
    {
        private const string DoughExceptionMessage = "Invalid type of dough.";
        private const string WeightExceptionMessage = "Dough weight should be in the range [1..200].";

        private Dictionary<string, double> flourTypeCalories = new Dictionary<string, double>
        {
            {"White", 1.5 },
            {"Wholegrain", 1.0 }
        };

        private Dictionary<string, double> bakingTechniqueCalories = new Dictionary<string, double>
        {
            {"Crispy", 0.9 },
            {"Chewy", 1.1 },
            {"Homemade", 1.0 }

        };

        private string bakingTechnique;
        private string flourType;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!flourTypeCalories.ContainsKey(value))
                {
                    throw new ArgumentException(DoughExceptionMessage);
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!bakingTechniqueCalories.ContainsKey(value))
                {
                    throw new ArgumentException(DoughExceptionMessage);
                }
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(WeightExceptionMessage);
                }
                weight = value;
            }
        }

        public double Calories
            => 2 * this.Weight * this.flourTypeCalories[this.FlourType]
                 * this.bakingTechniqueCalories[this.BakingTechnique];
    }
}
