namespace PartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()!.Split().ToList();

            string input = Console.ReadLine()!;

            while (input != "Party!")
            {
                string[] tokens = input.Split(" ");
                string command = tokens[0];
                string criteria = tokens[1];
                string value = tokens[2];

                if (command == "Remove")
                {
                    people.RemoveAll(GetPredicate(criteria, value));
                }
                else if (command == "Double")
                {
                    //people.AddRange(people.FindAll(GetPredicate(criteria,value)));

                    var doubles = people.FindAll(GetPredicate(criteria, value));

                    if (!doubles.Any())
                    {
                        input = Console.ReadLine()!;
                        continue;
                    }

                    int index = people.FindIndex(GetPredicate(criteria, value));

                    people.InsertRange(index, doubles);
                }

                input = Console.ReadLine()!;
            }

            Print(people);
        }
        private static Predicate<string> GetPredicate(string criteria, string value)
        {
            if (criteria == "StartsWith")
            {
                return x => x.StartsWith(value);

            }
            else if (criteria == "EndsWith")
            {
                return x => x.EndsWith(value);
            }
            else if (criteria == "Contains")
            {
                return x => x.Contains(value);
            }
            else
            {
                return x => x.Length == int.Parse(value);
            }
        }

        private static void Print(List<string> people)
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
                return;
            }
            Console.WriteLine($"{string.Join(" ", people)} are going to the party!");
        }
    }
}
