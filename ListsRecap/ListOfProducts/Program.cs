namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                list.Add(Console.ReadLine());
            }

            list.Sort();

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }

        }
    }
}