using SquareExercise;

Square square = new Square();

Console.WriteLine("Please enter a side length");

int side;

while(!int.TryParse(Console.ReadLine(), out side))
{
    Console.WriteLine("Not a valid side length, please enter again: ");
}

// int side = Int32.Parse(Console.ReadLine());

square.SideLength = side;

Console.WriteLine($"The perimeter of the square is {square.CalculatePerimeter()}");

Console.WriteLine();

Console.WriteLine($"The are of the square is {square.CalculateArea()}");


