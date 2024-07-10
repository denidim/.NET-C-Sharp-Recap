namespace LinkedList
{
    internal class Snake
    {
        private Random random = new Random();

        public Snake()
        {
            SnakeElements = new DoublyLinkedLIst<SnakeElement>();
        }

        public DoublyLinkedLIst<SnakeElement> SnakeElements { get; set; }

        public void DrawSnake()
        {
            Node<SnakeElement> snakeNode = SnakeElements.Head;

            while(snakeNode != null)
            {
                Console.SetCursorPosition(snakeNode.Value.Position.Col, snakeNode.Value.Position.Row);
                Console.WriteLine(snakeNode.Value.Character);
                snakeNode = snakeNode.Next;
            }
        }

        public void MoveSnake(Direction direction)
        {
            Node<SnakeElement> snakeHead = SnakeElements.Head;

            var newHead = new Node<SnakeElement>(new SnakeElement()
            {
                Position = new Position(snakeHead.Value.Position),
                Character = snakeHead.Value.Character,
            });

            SnakeElements.AddFirst(newHead);

            if(random.Next() % 20 != 0)
            {
                SnakeElements.RemoveLast();
            }

            if(direction == Direction.Right)
            {
                newHead.Value.Position.Col++;
            }
            else if(direction == Direction.Left)
            {
                newHead.Value.Position.Col--;
            }
            else if (direction == Direction.Up)
            {
                newHead.Value.Position.Row--;
            }
            else if (direction == Direction.Down)
            {
                newHead.Value.Position.Row++;    
            }
        }
    }
}
