//6

//bool loop6 = true;
//do
//{
//    Console.WriteLine("Hello, World!");

//    Console.WriteLine("Would you like to continue? y/n");
//    string choice = Console.ReadLine();
//    if (choice == "y")
//    {
//        loop6 = true;
//    }
//    else if (choice == "n")
//    {
//        loop6 = false;
//    }
//}
//while (loop6);

//do
//{
//    Console.WriteLine("Hello, World!");

//    Console.WriteLine("Would you like to continue? y/n");
//    string choice = Console.ReadLine();
//    if (choice == "y")
//    {
//        continue;
//    }
//    else if (choice == "n")
//    {
//        break;
//    }
//}
//while (true);

//---------------------------------------------
//7

//do
//{
//    Console.WriteLine("Enter some text:");
//    string userText = Console.ReadLine();

//    Console.WriteLine(userText);
//    Console.WriteLine("Would you like to continue? y/n");
//    string choice = Console.ReadLine();

//    if (choice == "y")
//    {
//        continue;
//    }
//    if (choice == "n")
//    {
//        break;
//    }
//} while (true);

//--------------------------------------------
//8

//do
//{

//    Console.WriteLine("Enter a number:");
//    double num1 = double.Parse(Console.ReadLine());
//    num1++; //shorthand for adding 1 to a number
//    Console.WriteLine(num1);

//    Console.WriteLine("Enter a number:");
//    double num2 = double.Parse(Console.ReadLine());
//    num2 += 0.5; //shorthand for add ontop of a number
//    Console.WriteLine(num2);

//    Console.WriteLine("Enter a number:");
//    double num3 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Enter a second number:");
//    double num4 = double.Parse(Console.ReadLine());
//    double num5 = num3 + num4;
//    Console.WriteLine(num5);

//    Console.WriteLine("Enter a number:");
//    double num6 = double.Parse(Console.ReadLine());
//    Console.WriteLine("Enter a second number:");
//    double num7 = double.Parse(Console.ReadLine());
//    double num8 = num6 * num7;
//    Console.WriteLine(num8);

//    Console.WriteLine("Would you like to continue? y/n");
//    string input = Console.ReadLine();
//    if(input == "y")
//    {
//        continue;
//    }
//    else if (input == "n")
//    {
//        break;
//    }
//}
//while (true);

//---------------------
//9

while (true)
{
    Console.WriteLine("Enter a language:");
    string language = Console.ReadLine();

    switch (language)
    {
        case "English":
            Console.WriteLine("Hello World!");
            break;
        case "Spanish":
            Console.WriteLine("Hola Mundo!");
            break;
        case "Dutch":
            Console.WriteLine("Hallo wereld!");
            break;
        default:
            Console.WriteLine("not supported");
            break;
    }

    Console.WriteLine("Would you like to continue? y/n");
    string input = Console.ReadLine();
    if (input == "y")
    {
        continue;
    }
    else if (input == "n")
    {
        break;
    }
}