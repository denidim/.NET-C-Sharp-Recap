using System;

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
            linkedList.AddFirst(new Node(4));

            linkedList.ForEach(n =>
            {
                Console.WriteLine(n.Value);
            });

            Console.WriteLine("Reversed");
            linkedList.Reverse();

            linkedList.ForEach(n =>
            {
                Console.WriteLine(n.Value);
            });

            Console.WriteLine("Reversed");
            linkedList.Reverse();

            linkedList.ForEach(n =>
            {
                Console.WriteLine(n.Value);
            });

            //foreach (var n in linkedList.ToArray())
            //{
            //    Console.WriteLine("In Foreach");
            //    Console.WriteLine(n.Value);
            //}
        }
    }
}
