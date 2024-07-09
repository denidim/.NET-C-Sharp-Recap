using System;

namespace LinkedList
{
    public class DoublyLinkedLIst<T>
    {
        private bool IsReversed = false;
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count = 0;

        public void Reverse()
        {
            IsReversed = !IsReversed;
        }

        public void ForEach(Action<Node<T>> action)
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

        public Node<T>[] ToArray()
        {
            Node<T>[] array = new Node<T>[Count];
            int i = 0;

            var node = Head;

            while (node != null)
            {
                array[i++] = node;
                node = node.Next;
            }

            return array.ToArray();
        }

        public Node<T> RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }
            Count--;
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

        public Node<T> RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }
            Count--;
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

        public void AddFirst(Node<T> node)
        {
            Count++;
            if (!CheckFirst(node))
            {
                Node<T> previousHead = Head;
                Head = node;
                previousHead.Previous = Head;
                Head.Next = previousHead;
            }
        }

        public void AddLast(Node<T> node)
        {
            Count++;
            if (!CheckFirst(node))
            {
                Node<T> previousTail = Tail;
                Tail = node;
                previousTail.Next = Tail;
                Tail.Previous = previousTail;
            }
        }

        private bool CheckFirst(Node<T> node)
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
