using System.Text.RegularExpressions;
//dividebyzeroexception
//int zero = 0;
//double sum = 5 / zero;

//formatexception
//int x = int.Parse("Egg");

//TRY CATCH


//double subtotal = 0.0;

//try
//{
//    Console.WriteLine("Enter subtotal:");
//    subtotal = double.Parse(Console.ReadLine());
//}
//catch (FormatException e)
//{
//    Console.WriteLine("Error! Invalid number");
//}
//catch (Exception e)
//{
//    Console.WriteLine("Error!");
//    Console.WriteLine(e.Message);
//}

////throwing our own exception
//int number = 0;
//try 
//{
//    Console.WriteLine("Please enter a number between 1-100");
//    number = int.Parse(Console.ReadLine());
//    if(number <= 0 || number >= 101)
//    {
//        //Throw your own exception
//        throw new Exception("Number is out of range");
//    }
//}
//catch(FormatException e)
//{
//    Console.WriteLine("Not a number");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

////validating loop
//int x = 0;
//while (true)
//{
//    try
//    {
//        Console.WriteLine("Please enter a positive number");
//        x = int.Parse(Console.ReadLine());
//        if (x <= 0)
//        {
//            throw new Exception("That was not a positive number");
//        }
//        else
//        {
//            //get out of loop
//            break;
//        }
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}


////tryParse
//Console.WriteLine("Please enter a number");
//string inputNumber = Console.ReadLine();
//double resultNum = 0;

//bool isDouble = double.TryParse(inputNumber, out resultNum);
////worked
//if(isDouble)
//{
//    Console.WriteLine(resultNum);
//}
////didn't work
//else
//{
//    Console.WriteLine("Was not a number");
//}

////Regex / Regular expressions  @"^\d\d\d-\d\d\d\d$"
//if (Regex.IsMatch("123.123.4567", @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$"))
//{
//    Console.WriteLine("That was a valid phone number");
//}
//else
//{
//    Console.WriteLine("That was not a valid phone number");
//}

//software demo
//Goal :get 2 numbers from the user, then add them together
//int num1 = 0;
//int num2 = 0;
//int num3 = 0;

//while (true)
//{
//    try
//    {
//        Console.WriteLine("Please enter a number");
//        num1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("Please enter a second number");
//        num2 = int.Parse(Console.ReadLine());
//        num3 = num1 + num2;
//        Console.WriteLine($"The two numbers added together = {num3}");
//        break;
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine("That was not a valid input");
//    }
//}

//Console.WriteLine($"These were the numbers you chose {num1} {num2}");



//Get a number.try catch it. Make sure its under 1000. Display it to the user once its a number. (Console writeline outside of the try catch)
//int under1k = 0;

//while (true)
//{
//    try
//    {
//        Console.WriteLine("Please enter a number under 1000");
//        under1k = int.Parse(Console.ReadLine());
//        if(under1k >= 1000)
//        {
//            throw new Exception("That number was too high");
//        }
//        else
//        {
//            break;
//        }
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}

//Console.WriteLine(under1k);

//Ask the user how much money they have in their bank account. use a TryParse to turn it into a number
//Console.WriteLine("How much money do you have in your account?");
//string bankInput = Console.ReadLine();

//double bankAmount = 0;
//bool isParsed = double.TryParse(bankInput, out bankAmount);

//if (isParsed)
//{
//    Console.WriteLine($"You have ${bankAmount} in your account");
//}

//Get an email from the user. Use Regex to confirm its an email
Console.WriteLine("Please give me your email");
string email = Console.ReadLine();

//if(Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
if (Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$"))
    
{
    Console.WriteLine("That was a valid email");
}
else
{
    Console.WriteLine("That was not valid");
}