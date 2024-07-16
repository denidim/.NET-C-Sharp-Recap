namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            string[] input = Console.ReadLine()!.Split();

            while (input[0] != "END")
            {
                string name = input[0];

                int age = int.Parse(input[1]);

                string town = input[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine()!.Split();
            }

            int position = int.Parse(Console.ReadLine()!);

            var personToCompare = people[position - 1];

            int matches = 0;
            int notEqual = 0;

            foreach (Person person in people)//.Where(x => x != personToCompare))
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    matches++;
                }
                else
                {
                    notEqual++;
                }
            }
            if (matches > 1)
            {
                Console.WriteLine($"{matches} {notEqual} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
