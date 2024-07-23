﻿namespace PizzaCalories
{
    internal class Dough
    {
        private const string DoughExceptionMessage = "Invalid type of dough.";
        private const string WeightExceptionMessage = "Dough weight should be in the range [1..200].";

        private Dictionary<string, double> flourTypeCalories = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1.0 }
        };

        private Dictionary<string, double> bakingTechniqueCalories = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }

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
                if (!flourTypeCalories.ContainsKey(value.ToLower()))
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
                if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
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
            => 2 * this.Weight * this.flourTypeCalories[this.FlourType.ToLower()]
                 * this.bakingTechniqueCalories[this.BakingTechnique.ToLower()];
    }
}
