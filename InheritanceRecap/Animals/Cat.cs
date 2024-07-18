namespace Animals
{
    public abstract class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            throw new NotImplementedException();
        }
    }
}