namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] newArr = new int[arr.Length];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int temp = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j-1] = arr[j];
                }
                arr[arr.Length-1] = temp;
            }
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}