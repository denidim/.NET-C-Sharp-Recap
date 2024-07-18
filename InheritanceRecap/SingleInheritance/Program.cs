namespace SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark(); 

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Weep();
            puppy.Bark();
        }
    }
}
