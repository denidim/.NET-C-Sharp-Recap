namespace PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nPokePower = int.Parse(Console.ReadLine());

            int fiftyPercentPower = nPokePower / 2;

            int mTargetDistance = int.Parse(Console.ReadLine());

            int yExhaustionFactor = int.Parse(Console.ReadLine());

            int poked = 0;

            while (nPokePower >= mTargetDistance)
            {
                nPokePower -= mTargetDistance;
                poked++;

                if (nPokePower == fiftyPercentPower && yExhaustionFactor > 0)
                {
                    nPokePower /= yExhaustionFactor;
                }
            }
            Console.WriteLine(nPokePower);
            Console.WriteLine(poked);
        }
    }
}
