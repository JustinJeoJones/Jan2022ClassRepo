// See https://aka.ms/new-console-template for more information
using Carbana;

Console.WriteLine("Hello. Welcome to CarBana");
Console.WriteLine("What is your price range?");
double priceRange = double.Parse(Console.ReadLine());

using(CarBanaDBContext context = new CarBanaDBContext())
{
    List<Car> carsInRange = context.Cars.Where(C => C.Price <= priceRange).ToList();
    foreach(Car c in carsInRange)
    {
        Console.WriteLine($"{c.Make} {c.Model}");
    }
    Console.WriteLine("Please enter the make and model of the car you want. example: Ford Focus");
    string choice = Console.ReadLine();
    Car result = carsInRange.First(c => $"{c.Make} {c.Model}" == choice);

    Console.WriteLine($"{result.Make} {result.Model} ${result.Price} {result.Mileage} miles");
}
