// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the GC Casino!");
int dice = getDice();
bool runProgram = true;
while (runProgram)
{
    int roll1 = getRandom(dice);
    int roll2 = getRandom(dice);
    Console.WriteLine($"You rolled a {roll1} and {roll2}. ({roll1 + roll2} total)");
    if(dice == 6)
    {
        DisplayCombo(roll1, roll2);
    }
    else if(dice == 20)
    {
        DnDCombos(roll1, roll2);
    }
    runProgram = getContinue();
}






//testing
//DisplayCombo(1,1);
//DisplayCombo(1,2);
//DisplayCombo(2,1);
//DisplayCombo(6, 6);
//DisplayCombo(6, 1);
//DisplayCombo(5, 6);
//DnDCombos(1, 1);
//DnDCombos(1, 2);
//DnDCombos(2, 1);
//DnDCombos(20, 20);
//DnDCombos(20, 3);
//DnDCombos(3, 20);
//DnDCombos(1, 20);


//methods
//Asks for dice sides and returns
static int getDice()
{
    Console.WriteLine("How many sides do you want your dice to have?");
    int diceSides = 0;
    while (true)
    {
        try
        {
            diceSides = int.Parse(Console.ReadLine());
            if (diceSides >= 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("That number was too low");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    return diceSides;
}

//gets random
static int getRandom(int sides)
{
    Random random = new Random();
    return random.Next(sides) + 1;
}

//DisplayCombo
static void DisplayCombo(int x, int y)
{
    //dice combos
    if(x == 1 && y == 1)
    {
        Console.WriteLine("Snake Eyes");
    }
    //checks both possible combinations
    else if ( (x == 1 && y == 2) || (x == 2 && y == 1) )
    {
        Console.WriteLine("Ace Deuce");
    }
    else if(x == 6 && y == 6)
    {
        Console.WriteLine("Box Cars");
    }

    //totals
    int total = x + y;
    if(total == 7 || total == 11)
    {
        Console.WriteLine("Win");
    }
    else if(total == 2 || total == 3 || total == 12)
    {
        Console.WriteLine("Craps");
    }
}

static void DnDCombos(int x, int y)
{
    if(x == 20 && y == 20)
    {
        Console.WriteLine("Super Success");
    }
    else if(x == 20 || y == 20)
    {
        Console.WriteLine("Success");
    }
    else if (x == 1 && y == 1)
    {
        Console.WriteLine("Super Failure");
    }
    else if(x == 1 || y == 1)
    {
        Console.WriteLine("Failure");
    }
}

static bool getContinue()
{
    bool choice = true;
    while (true)
    {
        Console.WriteLine("Roll again? y/n");
        string result = Console.ReadLine();
        if (result == "y")
        {
            choice = true;
            break;
        }
        else if (result == "n")
        {
            choice = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not valid");
        }
    }

    return choice;
}