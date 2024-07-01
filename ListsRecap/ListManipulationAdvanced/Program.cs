using System.Security.Cryptography.X509Certificates;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                bool changes = false;
                string commands = Console.ReadLine();

                if (commands == "end")
                {
                    if (changes)
                    {
                        Console.WriteLine(string.Join(" ", list));
                    }
                    break;
                }

                string[] tokens = commands.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        list.Add(int.Parse(tokens[1]));
                        changes = true;
                        break;
                    case "Remove":
                        list.Remove(int.Parse(tokens[1]));
                        changes = true;
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(tokens[1]));
                        changes = true;
                        break;
                    case "Insert":
                        list.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        changes = true;
                        break;
                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;
                    case "Contains":
                        if (list.Contains(int.Parse(tokens[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", list.FindAll(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", list.FindAll(x => x % 2 != 0)));
                        break;
                    case "Filter":
                        var result = Filter(tokens[1], int.Parse(tokens[2]), list);
                        Console.WriteLine(string.Join(" ", result));
                        break;
                }
            }
        }

        private static List<int> Filter(string condition, int number, List<int> list)
        {
            if (condition == ">")
            {
                return list.Where(x => x > number).ToList();
            }
            else if (condition == "<")
            {
                return list.Where(x => x < number).ToList();
            }
            else if (condition == ">=")
            {
                return list.Where(x => x >= number).ToList();
            }
            else 
            {
                return list.Where(x => x <= number).ToList();
            }
        }
    }
}