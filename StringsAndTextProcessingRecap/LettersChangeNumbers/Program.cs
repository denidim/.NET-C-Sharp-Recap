namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string sequence = input[i];

                double leftPosition = (double)sequence[0] % 32;
                double rightPosition = (double)sequence[sequence.Length - 1] % 32;
                string strNUmber = sequence.Substring(1, sequence.Length - 2);
                double number = double.Parse(strNUmber.ToString());

                if (char.IsUpper(sequence[0]))
                {
                    sum += number / leftPosition;
                }
                else
                {
                    sum += number * leftPosition;
                }

                if (char.IsUpper(sequence[sequence.Length - 1]))
                {
                    sum -= rightPosition;
                }
                else
                {
                    sum += rightPosition;
                }

            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
