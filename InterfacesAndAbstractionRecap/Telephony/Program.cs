namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();

            string[] sites = Console.ReadLine().Split();

            ICallable phone;

            foreach (string phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length < 10)
                {
                    phone = new Smartphone();
                    phone.Call(phoneNumber);
                }
                else
                {
                    phone = new StationaryPhone();

                    if (!phoneNumber.Any(x => char.IsDigit(x)))
                    {
                        Console.WriteLine("Invalid number!");
                        continue;
                    }
                    phone.Call(phoneNumber);
                }
            }

            IBrowseable phoneBrowseable;

            foreach (string urls in sites)
            {
                phoneBrowseable = new Smartphone();
                if (urls.Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URLs");
                    continue;
                }
                phoneBrowseable.Browse(urls);
            }
        }
    }
}
