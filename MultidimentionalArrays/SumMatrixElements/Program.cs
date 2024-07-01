namespace SumMatrixElements
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
                    sum += line[j];
                    matrix[i,j] = line[j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
        }

        public static int[] ReadIntArray()
        {
            return Console.ReadLine()!
                .Split(new string[] {" ",", " },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }
    }
}
