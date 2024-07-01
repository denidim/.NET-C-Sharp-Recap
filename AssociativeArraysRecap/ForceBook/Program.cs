namespace ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> keyValuePairs = new();

            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string[] delimiters = { " | ", " -> " };

                string[] data = input.Split(delimiters, StringSplitOptions.None);

                string force = string.Empty;
                string user = string.Empty;
                string command = string.Empty;

                if (input.Contains("|"))
                {
                    force = data[0];
                    user = data[1];
                    command = "add";
                }
                else
                {
                    force = data[1];
                    user = data[0];
                    command = "changeOrAdd";
                }
                if (command == "add")
                {
                    if (keyValuePairs.TryGetValue(force, out List<string>? value))
                    {
                        if (!value.Contains(user))
                        {
                            value.Add(user);
                        }
                    }
                    else
                    {
                        keyValuePairs.Add(force, new List<string> { user });
                    }
                }
                else
                {
                    var key = keyValuePairs.FirstOrDefault(x => x.Value.Contains(user)).Key;
                    if (key != null)
                    {
                        if (keyValuePairs[key].Contains(user))
                        {
                            keyValuePairs[key].Remove(user);
                        }
                    }
                    if (keyValuePairs.TryGetValue(force, out List<string>? value))
                    {
                        if (!value.Contains(user))
                        {
                            value.Add(user);
                            Console.WriteLine($"{user} joins the {force} side!");
                        }
                    }
                }
            }
            keyValuePairs
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToList()
                .ForEach(x =>
                {
                    Console.WriteLine($"Side: {x.Key}, Members: {x.Value.Count}");
                    foreach (var kv in x.Value.Order())
                    {
                        Console.WriteLine($"! {kv}");
                    }
                });
        }
    }
}
