namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            const int miningCrewConsummation = 26;

            const int finalMiningCrewConsummation = 26;

            const int dailyYieldDrop = 10;

            const int minYield = 100;

            int totalAmountExtracted = 0;

            int days = 0;

            while (yield >= minYield)
            {
                int amountAfterConsummation = 0;

                if (yield >= miningCrewConsummation)
                {
                    amountAfterConsummation = yield - miningCrewConsummation;
                }
                totalAmountExtracted += amountAfterConsummation;

                yield -= dailyYieldDrop;
                days++;
            }

            if (totalAmountExtracted >= finalMiningCrewConsummation)
            {
                totalAmountExtracted -= finalMiningCrewConsummation;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmountExtracted);
        }
    }
}