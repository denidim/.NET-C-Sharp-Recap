namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                string operation = commands[0];

                if (operation == "End")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                switch (operation)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int number = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(index, number);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(commands[1]);
                        if (indexToRemove < 0 || indexToRemove >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Shift":
                        string leftOrRight = commands[1];
                        int count = int.Parse(commands[2]);
                        if (leftOrRight == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int curr = numbers[0];
                                for (int j = 1; j < numbers.Count; j++)
                                {
                                    numbers[j - 1] = numbers[j];
                                }
                                numbers[numbers.Count - 1] = curr;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int last = numbers[numbers.Count - 1];
                                for (int j = numbers.Count-1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j-1];
                                }
                                numbers[0] = last;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
