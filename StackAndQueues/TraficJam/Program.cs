namespace TraficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            Queue<string> queue = new Queue<string>();
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "end")
                {

                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }
                if (input == "green")
                {
                    if (queue.Count < n)
                    {
                        n = queue.Count;
                    }
                    count += n;
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}
