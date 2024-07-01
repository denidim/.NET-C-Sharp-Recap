namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> keyValuePairs = new();

            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "End")
                {
                    break;
                }
                string companyName = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                if(keyValuePairs.TryGetValue(companyName, out List<string>? value))
                {
                    if(!value.Contains(id))
                    {
                        value.Add(id);
                    }
                }
                else
                {
                    keyValuePairs.Add(companyName, new List<string> { id });
                }
            }

            foreach (var kvp in keyValuePairs.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
