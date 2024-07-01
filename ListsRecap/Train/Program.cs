namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                string[] token = command.Split();

                if (token[0] == "end")
                {
                    Console.WriteLine(string.Join(" ",train));
                    break;
                }

                if (token[0] == "Add")
                {
                    train.Add(int.Parse(token[1]));
                }
                else
                {
                    int passengers = int.Parse(token[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagonPassengers = train[i];

                        if (currentWagonPassengers < maxCapacity)
                        {
                            int freeSpace = maxCapacity - currentWagonPassengers;

                            if (freeSpace >= passengers)
                            {
                                train[i] += passengers;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}