//Main

string value = "Justin";

Console.WriteLine(GreetUser(value));

ChangeName(ref value);
Console.WriteLine(value);


Secretname(out value);
Console.WriteLine(value);

//string secret = "";
//Secretname(out string secret);
//Console.WriteLine(secret);


//------------
//Methods

//Pass by Value (Default)
static string GreetUser(string user)
{
    return $"Hello {user}";
}

//Pass by Reference
static void ChangeName(ref string name)
{
    name = "Goku";
}

//Pass by Out
static void Secretname(out string sName)
{
    sName = "Hulk";
}
