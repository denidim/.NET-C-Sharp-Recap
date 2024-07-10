namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();

            snake.SnakeElements.AddFirst(new Node<SnakeElement>(new SnakeElement()
            {
                Character = '@',
                Position = new Position(13, 16)
            }));
            snake.SnakeElements.AddFirst(new Node<SnakeElement>(new SnakeElement()
            {
                Character = '@',
                Position = new Position(12, 16)
            }));
            snake.SnakeElements.AddFirst(new Node<SnakeElement>(new SnakeElement()
            {
                Character = '@',
                Position = new Position(11, 16)
            }));

            Direction direction = Direction.Up;

            while (true)
            {
                direction = ChangeDirection(direction);

                Console.Clear();

                Console.CursorVisible = false;

                snake.DrawSnake();

                snake.MoveSnake(direction);

                Thread.Sleep(200);
            }
        }

        private static Direction ChangeDirection(Direction direction)
        {
            if (Console.KeyAvailable)
            {
                var ch = Console.ReadKey(true).Key;
                switch (ch)
                {
                    case ConsoleKey.LeftArrow:
                        direction = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.Right;
                        break;
                    case ConsoleKey.UpArrow:
                        direction = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Direction.Down;
                        break;
                }
            }
            return direction;
        }
    }
}
