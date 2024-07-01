namespace SofUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool partyStarted = false;
            HashSet<string> vipPeople = new HashSet<string>();
            HashSet<string> regularPeople = new HashSet<string>();
            string input;

            while ((input=Console.ReadLine()!)!="END")
            {
                if(input == "PARTY")
                {
                    partyStarted = true;
                    continue;
                }
                if(partyStarted)
                {
                    vipPeople.Remove(input);
                    regularPeople.Remove(input);
                }
                else
                {
                    if(IsVip(input))
                    {
                        vipPeople.Add(input);
                    }
                    else
                    {
                        regularPeople.Add(input);
                    }
                }
            }
            Console.WriteLine(vipPeople.Count + regularPeople.Count);

            foreach (var item in vipPeople)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regularPeople)
            {
                Console.WriteLine(item);
            }
        }

        private static bool IsVip(string number)
        {
            return Char.IsDigit(number[0]);
        }
    }
}
