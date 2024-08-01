namespace MilitaryElite
{
    using Enums;
    using Interfaces;
    using Models;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            string command = Console.ReadLine().Trim();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string arg = cmdArgs[0];
                int id = int.Parse(cmdArgs[1]);
                string firstName = cmdArgs[2];
                string lastName = cmdArgs[3];

                if (arg == "Private")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);

                    ISoldier privateSoldier = new Private(id, firstName, lastName, salary);

                    soldiers.Add(privateSoldier);
                }
                else if (arg == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);

                    string[] privateIds = cmdArgs[5..];

                    List<IPrivate> thisPrivates = soldiers
                        .FindAll(x => privateIds.Contains(x.Id.ToString()))
                        .Select(x => x as IPrivate)
                        .ToList()!;

                    ISoldier soldier = new LieutenantGeneral(id, firstName, lastName, salary, thisPrivates);

                    soldiers.Add(soldier);
                }
                else if (arg == "Engineer")
                {
                    Enum.TryParse(cmdArgs[5], false, out SoldierCorpEnum corpsEnum);

                    if (corpsEnum == default)
                    {
                        continue;
                    }

                    decimal salary = decimal.Parse(cmdArgs[4]);

                    List<IRepair> repairs = new List<IRepair>();

                    string[] repairParts = cmdArgs[6..];

                    for (int i = 0; i < repairParts.Length; i += 2)
                    {
                        IRepair repair = new Repair(repairParts[i], int.Parse(repairParts[i + 1]));
                        repairs.Add(repair);
                    }

                    ISoldier soldier = new Engineer(id, firstName, lastName, salary, corpsEnum, repairs);

                    soldiers.Add(soldier);
                }
                else if (arg == "Commando")
                {
                    Enum.TryParse(cmdArgs[5], false, out SoldierCorpEnum corpsEnum);

                    if (corpsEnum == default)
                    {
                        continue;
                    }

                    decimal salary = decimal.Parse(cmdArgs[4]);

                    List<IMission> missions = new List<IMission>();

                    string[] missionsInfo = cmdArgs[6..];

                    for (int i = 0; i < missionsInfo.Length; i += 2)
                    {
                        Enum.TryParse(missionsInfo[i + 1], false, out MissionStateEnum missionStateEnum);

                        if (missionStateEnum != default)
                        {
                            IMission mission = new Mission(missionsInfo[i], missionStateEnum);

                            missions.Add(mission);
                        }
                    }

                    ISoldier soldier = new Commando(id, firstName, lastName, salary, corpsEnum, missions);

                    soldiers.Add(soldier);
                }
                else if (arg == "Spy")
                {
                    int codeNumber = int.Parse(cmdArgs[4]);

                    ISoldier spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(spy);
                }

                command = Console.ReadLine().Trim();
            }

            
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
