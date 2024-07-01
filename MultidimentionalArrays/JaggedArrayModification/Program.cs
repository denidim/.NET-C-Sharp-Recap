namespace JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[][] jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                jagged[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }
            while (true)
            {
                string[] strings = Console.ReadLine()!.Split();
                if (strings[0] == "END")
                {
                    break;
                }
                int row = int.Parse(strings[1]);
                int col = int.Parse(strings[2]);
                int value = int.Parse(strings[3]);

                if(!IsInMatrix(jagged, row, col))
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                switch (strings[0])
                {
                    case "Add": jagged[row][col] += value; break;
                    case "Subtract": jagged[row][col] -= value; break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsInMatrix<T>(T[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix[row].Length;
        }

    }
}
