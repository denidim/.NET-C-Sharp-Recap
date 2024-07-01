namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (array.Length > 1)
            {
                int[] condense = new int[array.Length-1];

                for (int i = 1; i < array.Length; i++)
                {
                    condense[i-1] = array[i - 1] + array[i];
                }
                array = condense;
            }
            Console.WriteLine(array[0]);
        }
    }
}