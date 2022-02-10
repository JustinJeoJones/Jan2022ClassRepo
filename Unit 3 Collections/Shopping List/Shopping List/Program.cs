Dictionary<string, decimal> menu = new Dictionary<string, decimal>() 
{
    ["Soda"] = 1.50M,
    ["Red Bull"] = 2.99M,
    ["Chips"] = 1.00M,
    ["Candy"] = 0.50M,
    ["Protein Bar"] = 2.50M,
    ["Water"] = 1.00M,
    ["Cough Drops"] = 3.99M,
    ["Takis"] = 1.99M
};

List<string> cart = new List<string>();
bool runProgram = true;
while (runProgram)
{
    //Clean up console after every item
    Console.Clear();
    //displaying menu
    foreach (KeyValuePair<string, decimal> item in menu.OrderBy(item => item.Value))
    {
        Console.WriteLine(string.Format("{0,-15} {1,15}",item.Key, item.Value));
    }

    //Asking for input
    Console.WriteLine("What would you like to order?");
    string choice = Console.ReadLine();

    //check if exists
    if (menu.ContainsKey(choice))
    {
        Console.WriteLine($"You purchased a {choice} for {menu[choice]}");
        cart.Add(choice);
        //Ask if continue
        while (true)
        {
            Console.WriteLine("Would you like to buy something else? y/n");
            string loopChoice = Console.ReadLine();
            if(loopChoice == "y")
            {
                runProgram = true;
                break;
            }
            else if(loopChoice == "n")
            {
                runProgram= false;
                break;
            }
            else
            {
                Console.WriteLine("That was not a valid input");
            }
        }
    }
    else
    {
        Console.WriteLine("That item does not exist");
    }

}

//display order
Console.WriteLine();
Console.WriteLine("This is your order:");
decimal total = 0;

//highest price
string highestName = "Candy";
//lowest price
string lowestName = "Cough Drops";
foreach(string item in cart)
{
    Console.WriteLine(string.Format("{0,-15} {1,15}", item, menu[item]));
    total += menu[item];
    if(menu[item]>= menu[highestName])
    {
        highestName = item;
    }
    if(menu[item]<= menu[lowestName])
    {
        lowestName = item;
    }
}
Console.WriteLine($"Average price per item in order was {Math.Round(total / cart.Count, 2)}");
Console.WriteLine($"The highest price item was {highestName}");
Console.WriteLine($"The lowest price item was {lowestName}");