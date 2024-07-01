namespace RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            
            HashSet<string> s = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine()!;

                s.Add(name);
            }

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
