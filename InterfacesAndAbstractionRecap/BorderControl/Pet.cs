
namespace BorderControl
{
    internal class Pet : IBirthable
    {
        public Pet(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public DateTime Birthdate { get; private set; }
    }
}
