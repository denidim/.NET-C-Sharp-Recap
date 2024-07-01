namespace PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = ReadIntArray();

            int[,] matrix = new int[ints[0], ints[1]];

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] line = ReadIntArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum+= matrix[i,i];
            }
            Console.WriteLine(sum);
        }
        public static int[] ReadIntArray()
        {
            return Console.ReadLine()!
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }
    }
}
