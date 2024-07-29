using System.Globalization;

namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine()!.Trim();

            List<IDentifiable> identifiables = new List<IDentifiable>();
            List<IBirthable> birthables = new List<IBirthable>();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Robot")
                {
                    string robotModel = cmdArgs[1];
                    string robotId = cmdArgs[2];
                    identifiables.Add(new Robot(robotModel, robotId));

                }
                else if (cmdArgs[0] == "Citizen")
                {
                    string citizenName = cmdArgs[1];
                    int citizenAge = int.Parse(cmdArgs[2]);
                    string citizenId = cmdArgs[3];
                    DateTime birthDate = DateTime.ParseExact(cmdArgs[4], "dd/M/yyyy", CultureInfo.InvariantCulture);
                    Citizen citizen = new Citizen(citizenName, citizenAge, citizenId, birthDate);
                    identifiables.Add(citizen);
                    birthables.Add(citizen);
                }
                else
                {
                    string petName = cmdArgs[1];
                    DateTime birthDate = DateTime.ParseExact(cmdArgs[2],"dd/M/yyyy",CultureInfo.InvariantCulture);
                    Pet pet = new Pet(petName, birthDate);
                    birthables.Add(pet);
                }

                command = Console.ReadLine()!.Trim();
            }

            int yearOfBirth = int.Parse(Console.ReadLine()!.Trim());

            var bornInTheSameYear = birthables.FindAll(x => x.Birthdate.Year == yearOfBirth);

            foreach (var item in bornInTheSameYear)
            {
                Console.WriteLine(item.Birthdate.ToString("dd/M/yyyy"));
            }
        }
    }
}
