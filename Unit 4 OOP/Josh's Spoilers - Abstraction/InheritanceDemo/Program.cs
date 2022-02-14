// See https://aka.ms/new-console-template for more information

using InheritanceDemo;

Circle circle = new Circle(5);

Console.WriteLine(circle.Radius);
Console.WriteLine(circle.CalculatePerimeter());
Console.WriteLine(circle.CalculateArea());


Triangle triangle = new Triangle(5,6);
Console.WriteLine(triangle.CalculateArea());
Console.WriteLine(triangle.CalculatePerimeter());

Console.WriteLine("ENTER the name of the shape: ");

TypeOfShape TypeOfShape = new TypeOfShape();

while(!Enum.TryParse(Console.ReadLine(), out TypeOfShape))
{
    Console.WriteLine("Not a valid shape");
}

triangle.Name = TypeOfShape;

Console.WriteLine("Your shape is a " + triangle.Name);

triangle.Name = TypeOfShape.Triangle;

// Movie myMovie = newMovie("Shrek", Genre.Comedy)

