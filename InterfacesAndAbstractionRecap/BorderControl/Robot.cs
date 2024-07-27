namespace BorderControl
{
    internal class Robot : IDentifiable
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Name {  get; set; }

        public string Id { get; set; }

        public bool CheckFakeId(string endsWith)
        {
            if (this.Id.EndsWith(endsWith))
            {
                return true;
            }

            return false;
        }
    }
}
