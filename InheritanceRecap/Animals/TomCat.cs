namespace Animals
{
    public class TomCat : Cat
    {
        public TomCat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}