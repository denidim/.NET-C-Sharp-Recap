namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                box.Elements.Add(int.Parse(Console.ReadLine()));
            }

            int valueToCompare = int.Parse(Console.ReadLine());

            int countOfElementsGreaterThan = box.CountOfElementsGreaterThan(valueToCompare);

            Console.WriteLine(countOfElementsGreaterThan);

        }
    }
}
