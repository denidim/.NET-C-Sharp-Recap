namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine()!.Trim();

            List<IDentifiable> identifiables = new List<IDentifiable>();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs.Length == 2)
                {
                    string robotModel = cmdArgs[0];
                    string robotId = cmdArgs[1];
                    identifiables.Add(new Robot(robotModel, robotId));

                }
                else
                {
                    string citizenName = cmdArgs[0];
                    int citizenAge = int.Parse(cmdArgs[1]);
                    string citizenId = cmdArgs[2];
                    identifiables.Add(new Citizen(citizenName, citizenAge, citizenId));
                }

                command = Console.ReadLine()!.Trim();
            }

            string lastDigitOfFakeIds = Console.ReadLine()!.Trim();

            foreach (var item in identifiables)
            {
                if (item.CheckFakeId(lastDigitOfFakeIds))
                {
                    Console.WriteLine(item.Id);
                }
            }

        }
    }
}
