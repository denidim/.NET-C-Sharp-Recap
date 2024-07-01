namespace pokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()!.Split().Select(s => int.Parse(s)).ToList();
            int result = 0;

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine()!);

                int removed = 0;

                if (index < 0)
                {
                    removed = list[0];
                    result+=removed;
                    list[0] = list[list.Count - 1];

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= removed)// increase
                        {
                            list[i] += removed;
                        }
                        else //decrease
                        {
                            list[i] -= removed;
                        }
                    }
                }
                else if (index > list.Count - 1)
                {
                    removed = list[list.Count - 1];
                    result += removed;
                    list[list.Count - 1] = list[0];

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= removed)// increase
                        {
                            list[i] += removed;
                        }
                        else //decrease
                        {
                            list[i] -= removed;
                        }
                    }
                }
                else
                {
                    removed = list[index];

                    result += removed;

                    list.RemoveAt(index);

                    if (list.Count == 0)
                    {
                        break;
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= removed)// increase
                        {
                            list[i] += removed;
                        }
                        else //decrease
                        {
                            list[i] -= removed;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
