namespace LinkedList
{
    public class DoublyLinkedLIst
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddFirst(Node node)
        {
            // Check first Node
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            else 
            {
                Node previousHed = Head;
                Head = node;
                previousHed.Previous = Head;
                Head.Next = previousHed;
            }
        private bool CheckFirst(Node node)
        }
    }
}
