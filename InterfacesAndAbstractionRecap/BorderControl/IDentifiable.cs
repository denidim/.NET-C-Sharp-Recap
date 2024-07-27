namespace BorderControl
{
    internal interface IDentifiable
    {
        string Name { get; }

        string Id { get; }

        bool CheckFakeId(string endsWith);
    }
}
