using System.Dynamic;

namespace MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GetMultipleOfEvenAndOdds(n);
        }

        private static void GetMultipleOfEvenAndOdds(int n)
        {
            int evenSum = GetSumOfEvenDigits(n);
            int oddSum = GetSumOfOddDigits(n);

            Console.WriteLine(evenSum * oddSum);
        }

        private static int GetSumOfEvenDigits(int n)
        {

            char[] chars = Math.Abs(n).ToString().ToArray();
            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                int number = int.Parse(chars[i].ToString());

                if (number % 2 == 0)
                {
                    sum += number;
                }    
            }

            return sum;
        }

        private static int GetSumOfOddDigits(int n)
        {
            char[] chars = Math.Abs(n).ToString().ToArray();
            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                int number = int.Parse(chars[i].ToString());

                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}