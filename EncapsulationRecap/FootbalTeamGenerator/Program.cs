using System.Numerics;

namespace FootballTeamGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine()!;
            List<Team> teams = new List<Team>();

            while (command != "END")
            {
                string[] cmdArgs = command.Split(';');

                if (cmdArgs[0] == "Team")
                {
                    try
                    {
                        teams.Add(new Team(cmdArgs[1]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else if (cmdArgs[0] == "Add")
                {
                    Team team = teams.FirstOrDefault(x => x.Name == cmdArgs[1])!;

                    if (team == null)
                    {
                        Console.WriteLine($"Team [{cmdArgs[1]}] does not exist.");
                    }

                    try
                    {
                        Player player = new Player(cmdArgs[2],
                                     int.Parse(cmdArgs[3]),
                                     int.Parse(cmdArgs[4]),
                                     int.Parse(cmdArgs[5]),
                                     int.Parse(cmdArgs[6]),
                                     int.Parse(cmdArgs[7]));

                        team!.AddPlayer(player);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (cmdArgs[0] == "Remove")
                {
                    Team team = teams.FirstOrDefault(x => x.Name == cmdArgs[1])!;

                    if (team == null)
                    {
                        Console.WriteLine($"Team [{cmdArgs[1]}] does not exist.");
                    }

                    if (!team.RemovePlayer(cmdArgs[2]))
                    {
                        Console.WriteLine($"Player {cmdArgs[2]} is not in the {cmdArgs[1]} team.");
                    }
                }
                else if (cmdArgs[0] == "Rating")
                {
                    Team team = teams.FirstOrDefault(x => x.Name == cmdArgs[1])!;

                    if (team == null)
                    {
                        Console.WriteLine($"Team [{cmdArgs[1]}] does not exist.");
                    }

                    Console.WriteLine($"{cmdArgs[1]} - {team.Stats}");
                }

                command = Console.ReadLine()!;
            }
        }
    }
}
