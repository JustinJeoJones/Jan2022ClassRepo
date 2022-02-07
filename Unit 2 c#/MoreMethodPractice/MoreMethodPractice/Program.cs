Console.WriteLine(Login("User", "Password"));
Console.WriteLine(Login("Usre", "Pasword"));

Console.WriteLine(GetPower(5,5));

Console.WriteLine(GetDiscount(205));
Console.WriteLine(GetDiscount(100));
Console.WriteLine(GetDiscount(51));


static bool Login(string user, string password)
{
    if(user == "User" && password == "Password")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static int GetPower(int value, int power)
{
    //int result = 1;
    //for(int i = 1; i <= power; i++)
    //{
    //    result *= value;
    //}
    //return result;

    return (int)Math.Pow(value, power);
}

static double GetDiscount(double money)
{
    if(money >= 200)
    {
        money = money * 0.8;
    }
    else if (money >= 100)
    {
        money = money * 0.85;
    }
    else if (money >= 50)
    {
        money = money * .9;
    }
    return money;
}