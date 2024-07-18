namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal;

            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                string type = input;

                string[] info = Console.ReadLine().Split();

                string name = info[0];

                int age = int.Parse(info[1]);

                string gender = info[2];

                if (type == "Cat")
                {
                    if (gender == "Male")
                    {
                        animal = new TomCat(name, age, gender);
                        Console.WriteLine(animal);
                        animal.ProduceSound();
                    }
                    else
                    {
                        animal = new Kitten(name, age, gender);
                        Console.WriteLine(animal);
                        animal.ProduceSound();
                    }
                }
                else if (type == "Dog")
                {
                    animal = new Dog(name, age, gender);
                    Console.WriteLine(animal);
                    animal.ProduceSound();
                }
                else if (type == "Frog")
                {
                    animal = new Frog(name, age, gender);
                    Console.WriteLine(animal);
                    animal.ProduceSound();
                }

                input = Console.ReadLine();
            }
        }
    }
}
