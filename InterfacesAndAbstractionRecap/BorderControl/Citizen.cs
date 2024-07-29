
namespace BorderControl
{
    internal class Citizen : Robot, IBirthable
    {
        public Citizen(string name, int age, string id, DateTime birthdate) : base(name, id)
        {
            Age = age;
            Birthdate = birthdate;
        }

        public int Age { get; set; }

        public DateTime Birthdate {  get; private set; }
    }
}
