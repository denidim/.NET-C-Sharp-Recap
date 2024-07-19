namespace EncapsulationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            //var percentage = decimal.Parse(Console.ReadLine());

            //persons.ForEach(p => p.IncreaseSalary(percentage));

            //persons.ForEach(p => Console.WriteLine(p.ToString()));


            //persons.OrderBy(p => p.FirstName)
            //.ThenBy(p => p.Age)
            //.ToList()
            //.ForEach(p => Console.WriteLine(p.ToString()));

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team.ToString());
        }
    }
}
