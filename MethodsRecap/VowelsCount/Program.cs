namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            PrintVowels(str);
        }

        private static void PrintVowels(string? str)
        {


            char[] vowels = new char[]
            {
                'a', 'e', 'i', 'o', 'u'
            };

            Console.WriteLine(str.ToLower().Count(x => vowels.Contains(x)));

            //int counter = 0;

            //foreach (var item in str.ToLower())
            //{
            //    if(vowels.Contains(item))
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(counter);
        }
    }
}