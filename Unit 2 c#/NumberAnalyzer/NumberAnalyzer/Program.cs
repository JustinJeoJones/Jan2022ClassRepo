// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();

bool runProgram = true;
while (runProgram)
{
    int input = 0;
    while(true)
    {
        Console.WriteLine(name + " Please enter a number between 1 - 100.");
        input = int.Parse(Console.ReadLine());
        if (input >=1 && input <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("That was out of range");
        }
    }
    

    //even
    if (input % 2 == 0)
    {
        //range check
        if (input <= 24)
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (input <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else
        {
            Console.WriteLine(input + " Even and greater than 60.");
        }
    }
    //odd
    else
    {
        //range check
        if (input < 60)
        {
            Console.WriteLine(input + " Odd and less than 60");
        }
        else
        {
            Console.WriteLine(input + " Odd and greater than 60");
        }
    }

    //end program
    while (true)
    {
        Console.WriteLine(name + " Would you like to continue? y/n");
        string loopCheck = Console.ReadLine();
        if (loopCheck.ToLower().Trim() == "y")
        {
            runProgram = true;
            break;
        }
        else if (loopCheck.ToLower().Trim() == "n")
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
Console.WriteLine("Goodbye " + name);