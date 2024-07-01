namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = ReadIntArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondaryDiagonal += matrix[i, matrix.GetLength(0)-1-i];
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
        private static int[] ReadIntArray()
        {
            return Console.ReadLine()!
                .Split(new string[] { "", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
