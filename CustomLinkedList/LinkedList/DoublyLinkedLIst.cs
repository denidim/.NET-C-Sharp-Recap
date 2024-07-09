using System;

namespace LinkedList
{
    public class DoublyLinkedLIst
    {
        private bool IsReversed = false;
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int Count = 0;

        public void Reverse()
        {
            IsReversed = !IsReversed;
        }

        public void ForEach(Action<Node> action)
        {
            var node = Head;
            if (IsReversed)
            {
                node = Tail;
            }
            while (node != null)
            {
                action(node);

                if (IsReversed)
                {
                    node = node.Previous;
                }
                else
                {
                    node = node.Next;
                }
            }
        }

        public Node[] ToArray()
        {
            Node[] array = new Node[Count];
            int i = 0;

            var node = Head;

            while (node != null)
            {
                array[i++] = node;
                node = node.Next;
            }

            return array.ToArray();
        }

        public Node RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }
            var previous = Tail;
            var newTail = Tail.Previous;
            if (newTail != null)
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
            if (newHead != null)
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
            Count++;
            if (!CheckFirst(node))
            {
                Node previousHead = Head;
                Head = node;
                previousHead.Previous = Head;
                Head.Next = previousHead;
            }
        }

        public void AddLast(Node node)
        {
            Count++;
            if (!CheckFirst(node))
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
