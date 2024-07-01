namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string[] input;
            while ((input = Console.ReadLine()!.Split(", "))[0] != "END" )
            {
                string direction = input[0];
                string number = input[1];

                if( direction == "IN")
                {
                    set.Add(number);
                }
                else
                {
                    set.Remove(number);
                }
            }

            if( set.Count < 1 )
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach( string number in set )
            {
                Console.WriteLine(number);
            }
        }
    }
}
