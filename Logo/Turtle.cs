namespace Logo
{
    internal class Turtle
    {
        int x = 10;
        int y = 5;
        ConsoleColor? pen = ConsoleColor.Yellow;
        Direction direction = Direction.Right;

        public void Go()
        {
            // justere posisjon ut fra retning
            if (direction == Direction.Left) x--;
            else if (direction == Direction.Right) x++;
            else if (direction == Direction.Down) y++;
            else if (direction == Direction.Up) y--;

            // tegne opp ruten vi kommer til, hvis penn er nede
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = pen.Value;
            var c = direction switch
            {
                Direction.Left => '<',
                Direction.Right => '>',
                Direction.Up => '^',
                Direction.Down => 'v',
            };

            Console.Write(c);
        }

        public void Turn(int angle)
        {
            if (direction == Direction.Right && angle == -1) direction = Direction.Up;
            else if (direction == Direction.Up && angle == 1) direction = Direction.Right;
            else direction++;
        }
    }
}
