namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] days = {
                "Monday", "Tuesday",
                "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday"
            };

            if (number < 1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            else
            {
                Console.WriteLine(days[number-1]);
            }
        }
    }
}