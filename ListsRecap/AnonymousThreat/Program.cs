namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()!.Split().ToList();

            var newArr = new List<string>();

            while (true)
            {
                string commands = Console.ReadLine()!;
                if (commands == "3:1")
                {
                    Console.WriteLine(string.Join(" ", input));
                    break;
                }
                else if (commands.Split()[0] == "merge")
                {
                    int startIndex = int.Parse(commands.Split()[1]);

                    int endIndex = int.Parse(commands.Split()[2]);

                    if (startIndex < 0 || startIndex >= input.Count)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1 || endIndex < 0)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        newArr.Add(input[i]);
                    }

                    input.RemoveRange(startIndex, newArr.Count);

                    string str = string.Join("", newArr);

                    newArr = new List<string>();

                    input.Insert(startIndex, str);
                }
                else
                {
                    int index = int.Parse(commands.Split()[1]);

                    int partitions = int.Parse(commands.Split()[2]);

                    string str = input[index];

                    input.RemoveAt(index);

                    int length = str.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            int count = str.Length - i * length;

                            newArr.Add(str.Substring(i * length, count));

                            break;
                        }
                        newArr.Add(str.Substring(i * length, length));
                    }
                    input.InsertRange(index, newArr);
                    newArr = new List<string>();

                }
            }
        }
    }
}
