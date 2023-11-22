using System.Text.Json;
using Logo;

Console.ForegroundColor = ConsoleColor.Black;

var json = File.ReadAllText(args[0]);
var program = JsonSerializer.Deserialize<Command[]>(json);

var turtle = new Turtle();
foreach (var command in program)
{
    if (command.Name == "go") turtle.Go();
    else if (command.Name == "turn") turtle.Turn(Convert.ToInt32(command.Parameter));
}


Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor= ConsoleColor.White;
Console.CursorTop = 15;

/*
 Versjon 3: 

   var program = new Command[]
   {
   new Command{Name = "go"},
   new Command{Name = "go"},
   new Command{Name = "turn", Parameter = "1"},
   new Command{Name = "go"},
   };
   
   var turtle = new Turtle();
   foreach (var command in program)
   {
   if (command.Name == "go") turtle.Go();
   else if (command.Name == "turn") turtle.Turn(Convert.ToInt32(command.Parameter));
   }
   
 */

/*
 Versjon 2: 

 Console.ForegroundColor = ConsoleColor.Black;
   var turtle1 = new Turtle();
   turtle1.Go();
   turtle1.Go();
   turtle1.Turn(1);
   turtle1.Go();
   
   var turtle2 = new Turtle();
   turtle2.Turn(-1);
   turtle2.Go();
   turtle2.Go();
   turtle2.Go();
   
   Console.BackgroundColor = ConsoleColor.Black;
   Console.CursorTop = 15;
    
 */

/*
Versjon 1


var x = 10;
var y = 5;
ConsoleColor? pen = ConsoleColor.Yellow;
var direction = Direction.Right;
Console.ForegroundColor = ConsoleColor.Black;

Go();
Go();
Turn(1);
Go();

Console.BackgroundColor = ConsoleColor.Black;
Console.CursorTop = 15;

void Go()
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

void Turn(int angle)
{
    if (direction == Direction.Right && angle == -1) direction = Direction.Up;
    else if (direction == Direction.Up && angle == 1) direction = Direction.Right;
    else direction++;
}
*/