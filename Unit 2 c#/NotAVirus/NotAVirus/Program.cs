//intro
Console.WriteLine("Welcome to your bank's credit score checker.");

//getting info
Console.WriteLine("Could you please enter your name!");
string name = Console.ReadLine();

Console.WriteLine("What is your favorite food?");
string favFood = Console.ReadLine();

Console.WriteLine("What is your mother's name?");
string mother = Console.ReadLine();

Console.WriteLine("What is your address?");
string address = Console.ReadLine();

Console.WriteLine("What is your credit card number?");
double cardNum = double.Parse(Console.ReadLine());

Console.WriteLine("What is your Account info?");
double accountNum = double.Parse(Console.ReadLine());

Console.WriteLine("What is your routing info?");
double routingNum = double.Parse(Console.ReadLine());

Console.WriteLine("What is your Social Security Number?");
double ssnNum = double.Parse(Console.ReadLine());

//displaying stolen info
Console.WriteLine("Thanks for the info " + name);
Console.WriteLine("You live at " + address + " and your favorite food is " + favFood);
Console.WriteLine("Your mother's name is " + mother);
Console.WriteLine("Your card number is " + cardNum + " and your bank info is Account: " + accountNum + " Routing: " + routingNum);
Console.WriteLine("Your social Security Number is " + ssnNum);

Console.WriteLine("Good luck stopping me :)");


