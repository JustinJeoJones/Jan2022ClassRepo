string[] names = { "Justin", "Lucas", "Aaliyah", "Jon", "Tarik", "Alex", "Josh" };
string[] foods = { "Baja Blast", "Sushi", "Chicken Wings", "Bacon", "Tacos", "Spaghetti", "Nalesniki" };
string[] home = { "Wyoming", "Louisville", "Manchester", "Toledo", "Queens NY", "Ferndale", "Cali" }; 

Console.WriteLine("Welcome to the student database!");

bool runProgram = true;

while (runProgram)
{
    //prompt for input
    int choice = 0;
    while(true)
    {
        Console.WriteLine($"Which student would you like to know more about? 1-{names.Length}");
        for(int i = 0; i< names.Length; i++)
        {
            Console.WriteLine($"{i+1}. {names[i]}");
        }
        string sName = Console.ReadLine();
        if (names.Contains(sName))
        {
            choice = Array.IndexOf(names, sName);
            break;
        }

        choice = int.Parse(sName) - 1;
        if (choice >= 0 && choice < names.Length)
        {
            //correct
            break;
        }
        else
        {
            Console.WriteLine("That was not a valid input");
        }
    }
    

    //Print info
    Console.WriteLine($"You have chosen {names[choice]}");

    while (true)
    {
        Console.WriteLine("Would you like to learn about the Hometown or Favorite Food?");
        string category = Console.ReadLine();

        //display category
        if (category.ToLower().Trim() == "hometown"|| category.ToLower().Trim() == "home" || category.ToLower().Trim() == "town")
        //if ("hometown".Contains(category.ToLower().Trim()))
        {
            Console.WriteLine($"{names[choice]} is from {home[choice]}");
            break;
        }
        else if (category.ToLower().Trim() == "favorite food" || category.ToLower().Trim() == "favorite" || category.ToLower().Trim() == "food")
        //else if ("favorite food".Contains(category.ToLower().Trim()))
        {
            Console.WriteLine($"{names[choice]}'s favorite food is {foods[choice]}");
            break;
        }
        else
        {
            Console.WriteLine("That was not a valid input");
        }
    }
    

    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string loopChoice = Console.ReadLine();
        if(loopChoice.ToLower().Trim() == "y")
        {
            runProgram = true;
            break;
        }
        else if (loopChoice.ToLower().Trim() == "n")
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