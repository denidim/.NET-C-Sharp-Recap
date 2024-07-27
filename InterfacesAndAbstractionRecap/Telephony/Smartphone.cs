namespace Telephony
{
    internal class Smartphone : StationaryPhone, IBrowseable
    {
        public void Browse(string url) => Console.WriteLine($"Browsing {url}");
    }
}
