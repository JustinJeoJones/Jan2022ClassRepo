// See https://aka.ms/new-console-template for more information
using Circle_Lab;

Console.WriteLine("Welcome to the Circle Tester");
//test();

//loop
bool runProgram = true;
List<Circle> myCircles = new List<Circle>();

while (runProgram)
{
    double result = Validator.getUserRadius();

    //create a circle
    Circle circle = new Circle(result);
    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
    Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
    myCircles.Add(circle);

    //Get if they want to continue
    runProgram = Validator.getContinue();

}

//Goodbye message
Console.WriteLine($"Goodbye. You created {myCircles.Count} circles");


//Method



static void test()
{
    Circle c = new Circle(5);
    Console.WriteLine(c.Radius);
    Console.WriteLine(c.CalculateCircumference());
    Console.WriteLine(c.CalculateFormattedCircumference());
    Console.WriteLine(c.CalculateArea());
    Console.WriteLine(c.CalculateFormattedArea());
    
}