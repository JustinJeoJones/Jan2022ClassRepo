// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to learning exponents.");

//looping program
bool runProgram = true;
while (runProgram)
{
    int value = 0;
    //Ask for user input
    while(true)
    {
        Console.WriteLine("Please enter a number. It cannot be 0 or negative");
        value = int.Parse(Console.ReadLine());
        if (value > 0 && value < 1291)
        {
            break;
        }
        else if(value >= 1291)
        {
            Console.WriteLine("That number was too large for this program");
        }
        else
        {
            Console.WriteLine("That value was too low");
        }
    }
    

    DisplayTable(value);

    //Ask if continue
    while(true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if (choice.Trim().ToLower() == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice.Trim().ToLower() == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not a valid input");
        }
    }
   
}

//---------------
//Methods
//Displaying table
static void DisplayTable(int num)
{
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));

    for(int i = 1; i <= num; i++)
    {
        //Console.WriteLine($"{i}\t{getSquared(i)}\t{getCubed(i)}");
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, getSquared(i), getCubed(i)));
    }
}

static int getSquared(int x)
{
    return x * x;
}

static int getCubed(int x)
{
    return x * x * x;
}