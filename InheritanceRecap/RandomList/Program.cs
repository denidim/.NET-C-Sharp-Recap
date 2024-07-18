namespace RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list =  new MyList<string>();

            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");

            Console.WriteLine("Random element: " + list.GetRandom());

            Console.WriteLine("Removed random: " + list.RemoveRandom());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
