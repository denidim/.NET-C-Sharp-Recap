using System;

namespace LinkedList
{
    public class DoublyLinkedLIst
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void ForEach(Action<Node> action)
        {
            var node = Head;
            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }

        public Node RemoveLast()
        {
            if(Tail == null)
            {
                return null;
            }
            var previous = Tail;
            var newTail = Tail.Previous;
            if( newTail != null)
            {
                newTail.Next = null;
            }
            else
            {
                Head = null;
            }
            Tail = newTail;

            return previous;
        }

        public Node RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }
            var previous = Head;
            var newHead = Head.Next;
            if(newHead != null)
            {
                newHead.Previous = null;//next element becomes first and remove its previous
            }
            else
            {
                Tail = null;
            }
            Head = newHead;

            return previous;
        }

        public void AddFirst(Node node)
        {
            if(!CheckFirst(node))
            {
                Node previousHead = Head;
                Head = node;
                previousHead.Previous = Head;
                Head.Next = previousHead;
            }
        }

        public void AddLast(Node node)
        {
            if(!CheckFirst(node))
            {
                Node previousTail = Tail;
                Tail = node;
                previousTail.Next = Tail;
                Tail.Previous = previousTail;
            }
        }

        private bool CheckFirst(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return true;
            }
            return false;
        }
    }
}
