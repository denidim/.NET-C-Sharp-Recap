using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            BigInteger snowballQuality = 0;
            BigInteger snowballValue = 0;

            for (int i = 0; i < numbersOfSnowballs; i++)
            {
                BigInteger snow = BigInteger.Parse(Console.ReadLine());

                BigInteger time = BigInteger.Parse(Console.ReadLine());

                int quality = int.Parse(Console.ReadLine());

                BigInteger result = BigInteger.Pow(snow / time, quality);

                if (result > snowballValue)
                {
                    snowballValue = result;
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
        }
    }
}