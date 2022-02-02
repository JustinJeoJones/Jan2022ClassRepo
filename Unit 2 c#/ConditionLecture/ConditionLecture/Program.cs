// See https://aka.ms/new-console-template for more information

//if statement
int age = 15;
if(age >= 21)
{
    Console.WriteLine("You are old enough to drink");
}
else if (age >= 18)
{
    Console.WriteLine("You are old enough to vote");
}
else if (age >= 16)
{
    Console.WriteLine("You are old enough to drive");
}
else
{
    Console.WriteLine("You are still a baby");
}

//Switch statement
Console.WriteLine("Choose a number. 1 2 3");
int menuChoice = int.Parse(Console.ReadLine());

switch (menuChoice)
{
    case 1:
        Console.WriteLine("You chose the first option");
        break;
    case 2:
        Console.WriteLine("You chose the second option");
        break;
    case 3:
        Console.WriteLine("You chose the third option");
        break;
    default:
        Console.WriteLine("That was not a choice");
        break;
}

//ternary operator
double temp = 70;

bool isHot = temp >= 70 ? true : false;
Console.WriteLine("Is it hot outside? " + isHot);
string dangerLevel = temp >= 100 ? "It is Scorching out there." : "It is safe to go out";
Console.WriteLine(dangerLevel);

//Loops
//While loop
int targetNumber = 10;
int startingNumber = 0;

while(startingNumber <= targetNumber)
{
    Console.WriteLine(startingNumber);
    startingNumber++;
}

bool continueRunning = true;
while (continueRunning)
{
    Console.WriteLine("Do you want to keep looping? y/n");
    string loopChoice = Console.ReadLine();
    if(loopChoice == "y")
    {
        continueRunning = true;
    }
    else if(loopChoice == "n")
    {
        continueRunning = false;
    }
}

//do while loop
int selection = 0;
do
{
    Console.WriteLine("Please enter a number that is not 0");
    selection = int.Parse(Console.ReadLine());
} while (selection == 0);

//For loop
for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

//messed up almost infinite loop
//for (int i = 0; i >= -1; i++)
//{
//    Console.WriteLine(i);
//}

//foreach 
int[] numbers = { 1, 10, 4678, 99, 2, 0, 1 };
foreach(int number in numbers)
{
    Console.WriteLine(number);
}

//break
while (true)
{
    Console.WriteLine("Type b for break. Type c for continue");
    string bChoice = Console.ReadLine();
    if(bChoice == "b")
    {
        break;
    }
    else if(bChoice == "c")
    {
        continue;
    }

    Console.WriteLine("That wasn't a choice");
}
