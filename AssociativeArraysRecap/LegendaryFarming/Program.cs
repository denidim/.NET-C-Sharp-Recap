using System.Collections.Generic;

namespace LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            Dictionary<string, int> junk = new();

            bool win = false;

            while (true)
            {
                if(win)
                {
                    break;
                }

                string line = Console.ReadLine()!;

                List<string> input = line.Split().ToList();

                for (int i = 1; i < input.Count; i += 2)
                {
                    int quantity = int.Parse(input[i - 1]);

                    string material = input[i].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            win = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk[material] = quantity;
                        }
                    }
                }
            }
            var key = keyMaterials.Where(x => x.Value >= 250).FirstOrDefault().Key;
            keyMaterials[key] -= 250;

            if (key == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (key == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            //var sorted = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary();

            keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));
            //foreach (var keyValuePair in keyMaterials.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            //{
            //    Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            //}

            junk.OrderBy(x => x.Key).ToList().ForEach(kvp => Console.WriteLine($"{kvp.Key}: {kvp.Value}"));
            //foreach (var kvp in junk.OrderBy(x => x.Key))
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}
        }
    }
}