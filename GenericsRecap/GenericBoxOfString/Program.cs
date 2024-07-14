namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",4);

            var personInfo = new Threeuple<string, string, string>($"{input[0]} {input[1]}", input[2], input[3]);

            string[] nameBeer = Console.ReadLine().Split();

            var beerInfo = new Threeuple<string, int, string>(nameBeer[0], int.Parse(nameBeer[1]), nameBeer[2]);

            string[] bankAcc = Console.ReadLine().Split();

            var numbersInfo = new Threeuple<string, double, string>(bankAcc[0], double.Parse(bankAcc[1]), bankAcc[2]);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
