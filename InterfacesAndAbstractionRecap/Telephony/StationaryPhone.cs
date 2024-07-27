namespace Telephony
{
    internal class StationaryPhone : ICallable
    {
        public void Call(string phoneNumber) => Console.WriteLine($"Calling... {phoneNumber}");
    }
}
