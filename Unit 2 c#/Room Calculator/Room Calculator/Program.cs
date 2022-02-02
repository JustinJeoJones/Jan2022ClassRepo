// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Room Calculator!");

//ask for user input
Console.WriteLine("Please enter a length.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a width");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a height");
double height = double.Parse(Console.ReadLine());

//Calculations
double area = length * width;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = 2 * ((width * length) + (height * length) + (height * width));

//Display results
Console.WriteLine("Area:" + area);
Console.WriteLine("Perimeter:" + perimeter);
Console.WriteLine("Volume:" + volume);
Console.WriteLine("Surface Area:" + surfaceArea);

//Room Size Challenge
if(area <= 250)
{
    Console.WriteLine("This is a small room");
}

else if(area > 250 && area < 650)
{
    Console.WriteLine("This is a medium room");
}
else if(area >= 650)
{
    Console.WriteLine("This is a large room");
}


//goodbye message
Console.WriteLine("Thanks for using the app!");