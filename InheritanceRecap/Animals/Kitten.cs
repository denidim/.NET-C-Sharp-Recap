namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}