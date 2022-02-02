/* Written by: Justin
 * Not Copywritten
 * Grand circus
 * I chose cyndaquil
*/

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to the class");

//Getting user input
Console.WriteLine("Please enter your name.");
//storing user input in variable name
string name = Console.ReadLine();
Console.WriteLine(name);


//Creating a variable
int age = 90000;

//Creating a constant
const double TAXRATE = 0.06;
//Doesn't work. Cannot change constants
//TAXRATE = 1


//Area of circle
Console.WriteLine("Please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry);
double value = double.Parse(Console.ReadLine());
double area = Math.PI * value * value;
Console.WriteLine(area);

//arithmetic symbols
Console.WriteLine(5 + 5);
Console.WriteLine(5 - 5);
Console.WriteLine(5 * 5);
Console.WriteLine(5 / 5);
Console.WriteLine(5%5);
Console.WriteLine(area++);
Console.WriteLine(area);
Console.WriteLine(area--);
Console.WriteLine(area);
Console.WriteLine(-5);

//Assignment
double bank = 0;
//won a bet
bank += 5;
Console.WriteLine(bank);
//Shoveled driveways
bank += 20;
Console.WriteLine(bank);
//Celebrate with taco bell
bank -= 5.99;
Console.WriteLine(bank);
//Bills
bank -= 1000;
bank -= 50;
bank -= 60;
Console.WriteLine(bank);

//Casting (converting datatypes)

int myInt = 7; //less precise
double myDouble = 32.51; //more precise

double castedDouble = myInt;
Console.WriteLine(castedDouble);

int castedInt = (int)myDouble;
Console.WriteLine(castedInt);