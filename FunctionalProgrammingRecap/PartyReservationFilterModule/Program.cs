namespace PartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()!.Split().ToList();

            string input = Console.ReadLine()!;

            Dictionary<string, Predicate<string>> predicatesByFilter = new Dictionary<string, Predicate<string>>();

            while (input != "Print")
            {
                string[] tokens = input.Split(';');
                string command = tokens[0];
                string filterType = tokens[1];
                string value = tokens[2];

                if (command == "Remove filter")
                {
                    predicatesByFilter.Remove(filterType + value);
                }
                else if (command == "Add filter")
                {
                    predicatesByFilter[filterType + value] = GetPredicate(filterType, value);
                }
                input = Console.ReadLine()!;
            }
            // apply predicates - only remove ppl
            foreach (var kvp in predicatesByFilter)
            {
                people.RemoveAll(kvp.Value);
            }

            Print(people);
        }
        private static Predicate<string> GetPredicate(string criteria, string value)
        {
            if (criteria == "Starts with")
            {
                return x => x.StartsWith(value);

            }
            else if (criteria == "Ends with")
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
