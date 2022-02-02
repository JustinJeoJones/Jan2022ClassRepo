//main
string value = ReturnHelloUser("Justin");

Console.WriteLine(value);
Console.WriteLine(ReturnHelloUser("Dustin"));
SayGoodbye();

Console.WriteLine(adder(3,7));
Console.WriteLine(subber(3,7));
Console.WriteLine(multi(3,7));
Console.WriteLine(divi(3,7));
CountUp(7);
CountDown(7);
Console.WriteLine(convertMinuteToSeconds(2));
Console.WriteLine(areaTriangle(5, 4));

Console.WriteLine(convertNegative(10));
Console.WriteLine(convertNegative(0));
Console.WriteLine(convertNegative(-3));

Console.WriteLine(convertPositive(10));
Console.WriteLine(convertPositive(0));
Console.WriteLine(convertPositive(-3));

greetUser();
Console.WriteLine(getRandom(21));


//methods
static string ReturnHelloUser(string user)
{
    string greeting = $"Hello {user}!";
    return greeting;
}
////overloaded
//static string ReturnHelloUser()
//{
//    string greeting = "Hello user!";
//    return greeting;
//}

static void SayGoodbye()
{
    Console.WriteLine("Have a good day!");
}

static double adder(double x, double y)
{
    return x + y;
}

static double subber(double x, double y)
{
    return x - y;
}

static double multi(double x, double y)
{
    return x * y;
}

static double divi(double x, double y)
{
    return x / y;
}

//exercises
//Count up

static void CountUp(int x)
{
    for(int i = 1; i <= x; i++)
    {
        Console.WriteLine(i);
    }
}

//Count Down
static void CountDown(int x)
{
    for(int i = x; i>=1; i--)
    {
        Console.WriteLine(i);
    }
}

//Convert minutes to seconds
static int convertMinuteToSeconds(int minutes)
{
    return minutes * 60;
}

static double areaTriangle(double tHeight, double tBase)
{
    return (tHeight * tBase) / 2;
}

static int convertNegative(int x)
{
    if(x <= 0)
    {
        return x;
    }
    else
    {
        return x * -1;
    }
}

static int convertPositive(int x)
{
    if( x >= 0)
    {
        return x;
    }
    else
    {
        return x * -1;
    }
}

static void greetUser()
{
    Console.WriteLine("Please enter your name.");
    string name = Console.ReadLine();

    Console.WriteLine($"Hello {name}");
}

static int getRandom(int max)
{
    Random rnd = new Random();
    //We put a +1 to make sure its in the range we want
    //0-max
    //return rnd.Next(max + 1);

    //1-max
    return rnd.Next(max) + 1;
}