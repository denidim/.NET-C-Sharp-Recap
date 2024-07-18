namespace Zoo
{
    internal class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
