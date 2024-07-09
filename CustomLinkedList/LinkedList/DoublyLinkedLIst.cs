﻿namespace LinkedList
{
    public class DoublyLinkedLIst
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

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
