namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while(true)
            {
                string commands = Console.ReadLine();

                if(commands == "end")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }

                string[] tokens = commands.Split();
                string command = tokens[0];

                switch(command)
                {
                    case "Add":
                        list.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                }
            }
        }
    }
}