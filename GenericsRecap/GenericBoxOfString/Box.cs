using System.Text;

namespace GenericBoxOfString
{
    internal class Box<T>
        where T : IComparable
    {
        public Box()
        {
            Elements = new List<T>();
        }
         
        public List<T> Elements { get; set; }


        public int CountOfElementsGreaterThan(T valueToCompare) => Elements.Count(x=>x.CompareTo(valueToCompare) > 0);

        public void Swap(int firstIndex, int secondIndex)
        {
            var curr = Elements[firstIndex];
            Elements[firstIndex] = Elements[secondIndex];
            Elements[secondIndex] = curr;
        }

        public override string ToString() => string.Join("\n\r", Elements.Select(x=>$"{typeof(T)}: {x}"));
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
