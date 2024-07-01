
namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> party = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                string name = command[0];

                bool exists = party.Any(x => x == name);

                if (command[command.Length - 2] == "not")
                {
                    if (exists)
                    {
                        party.Remove(name);
                        continue;
                    }
                    Console.WriteLine($"{name} is not in the list!");
                }
                else
                {
                    if (exists)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    party.Add(name);
                }
            }
            Console.WriteLine(string.Join("\n", party));
        }
    }
}