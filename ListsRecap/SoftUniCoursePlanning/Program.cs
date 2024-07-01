namespace SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()!.Split(", ").ToList();

            while (true)
            {
                string input = Console.ReadLine()!;

                if (input == "course start")
                {
                    int counter = 0;
                    foreach (string s in schedule)
                    {
                        Console.WriteLine($"{++counter}.{s}");
                    }
                    break;
                }

                string[] commands = input!.Split(":");

                if (commands[0] == "Add")
                {
                    if (!schedule.Contains(commands[1]))
                    {
                        schedule.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    if (!schedule.Contains(commands[1]))
                    {
                        schedule.Insert(int.Parse(commands[2]), commands[1]);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (schedule.Contains(commands[1]))
                    {
                        if (schedule.Contains($"{commands[1]}-Exercise"))
                        {
                            schedule.Remove($"{commands[1]}-Exercise");
                        }
                        schedule.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Swap")
                {
                    if (schedule.Contains(commands[1]) && schedule.Contains(commands[2]))
                    {
                        int indexCommandOne = schedule.IndexOf(commands[1]);

                        int indexCommandTwo = schedule.IndexOf(commands[2]);

                        schedule[indexCommandOne] = commands[2];
                        schedule[indexCommandTwo] = commands[1];


                        if (schedule.Contains($"{commands[1]}-Exercise"))
                        {
                            int indexCommandOneExercise = schedule.IndexOf($"{commands[1]}-Exercise");
                            schedule.RemoveAt(indexCommandOneExercise);
                            schedule.Insert(schedule.IndexOf(commands[1]) + 1, $"{commands[1]}-Exercise");
                        }

                        if (schedule.Contains($"{commands[2]}-Exercise"))
                        {
                            int indexCommandTwoExercise = schedule.IndexOf($"{commands[2]}-Exercise");
                            schedule.RemoveAt(indexCommandTwoExercise);
                            schedule.Insert(schedule.IndexOf(commands[2]) + 1, $"{commands[2]}-Exercise");
                        }
                    }
                }
                else if (commands[0] == "Exercise")
                {
                    if (!schedule.Contains(commands[1]))
                    {
                        schedule.Add(commands[1]);
                    }

                    int index = schedule.IndexOf(commands[1]);

                    if (!schedule.Contains($"{commands[1]}-Exercise"))
                    {
                        schedule.Insert(index + 1, $"{commands[1]}-Exercise");
                    }
                }
            }

        }
    }
}
