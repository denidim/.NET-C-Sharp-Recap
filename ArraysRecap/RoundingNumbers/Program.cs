﻿namespace RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                 .Split()
                                 .Select(double.Parse)
                                 .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }

                int rounded = (int)Math.Round(numbers[i],
                    MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {rounded}");
            }

        }
    }
}