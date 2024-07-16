namespace EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashPerson = new HashSet<Person>();
            SortedSet<Person> sortedPerson = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split();

                var person = new Person(personInfo[0], int.Parse(personInfo[1]));

                hashPerson.Add(person);
                sortedPerson.Add(person);
            }

            Console.WriteLine(hashPerson.Count);
            Console.WriteLine(sortedPerson.Count);
        }
    }
}
