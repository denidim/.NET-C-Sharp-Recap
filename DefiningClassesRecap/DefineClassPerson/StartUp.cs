namespace DefineClassPerson
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Family family = new Family();

            Person person;

            for (int i = 0; i <n; i++)
            {
                string[] nameAge = Console.ReadLine()!.Split();

                string name = nameAge[0];

                int age = int.Parse(nameAge[1]);

                person = new Person(name,age);

                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
