namespace BorderControl
{
    internal class Citizen : Robot
    {
        public Citizen(string name, int age, string id) : base(name, id)
        {
            Age = age;
        }

        public int Age { get; set; }
    }
}
