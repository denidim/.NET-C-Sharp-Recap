namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            PrintGrade(grade);
        }

        private static void PrintGrade(decimal grade)
        {
            if (grade >= 2.00m && grade <= 2.99m)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00m && grade <= 3.49m)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50m && grade <= 4.49m)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50m && grade <= 5.49m)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50m && grade <= 6.00m)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}