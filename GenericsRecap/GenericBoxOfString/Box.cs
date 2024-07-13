using System.Text;

namespace GenericBoxOfString
{
    internal class Box<T>
    {
        public List<T> elements { get; set; }

        public Box()
        {
            elements = new List<T>();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var curr = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = curr;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < elements.Count; i++)
            {
                sb.AppendLine($"{elements[i].GetType()}: {elements[i]}");

            }
            return sb.ToString().TrimEnd();
        }
    }
}
