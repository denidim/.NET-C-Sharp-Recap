namespace ListyIteratorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var listyIterator = new ListyIterator<string>(input.Skip(1).ToArray());

            string command = Console.ReadLine();

            try
            {
                while (command != "END")
                {
                    if (command == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }

                    command = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
