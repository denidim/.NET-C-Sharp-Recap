namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", array));
                    break;
                }

                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    array.RemoveAll(x => x == element);
                }

                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    array.Insert(position, element);
                }
            }
        }
    }
}