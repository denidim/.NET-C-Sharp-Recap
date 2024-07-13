using System.Text;

namespace GenericBoxOfString
{
    internal class Box<T>
    {
        public Box()
        {
            elements = new List<T>();
        }

        public List<T> elements { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            var curr = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = curr;
        }

        public override string ToString() => string.Join("\n\r", elements.Select(x=>$"{typeof(T)}: {x}"));
        //{
        //    var sb = new StringBuilder();

        //    for (int i = 0; i < elements.Count; i++)
        //    {
        //        sb.AppendLine($"{elements[i].GetType()}: {elements[i]}");

        //    }
        //    return sb.ToString().TrimEnd();
        //}
    }
}
