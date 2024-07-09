namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //LinkedListNode<int> node = list.First;
            //while (node != null)
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;
            //}

            var linkedList = new DoublyLinkedLIst();

            linkedList.AddFirst(new Node(1));
            linkedList.AddFirst(new Node(2));
            linkedList.AddFirst(new Node(3));
            linkedList.AddLast(new Node(1));
            linkedList.AddLast(new Node(2));
            linkedList.AddLast(new Node(3));

            Node node = linkedList.Head;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
