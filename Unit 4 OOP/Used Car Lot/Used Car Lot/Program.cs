using Used_Car_Lot;

CarLot carlot = new CarLot();

bool runProgram = true;

while (runProgram)
{
    carlot.DisplayCars();
    Console.WriteLine($"{carlot.cars.Count + 1} Add a car");
    Console.WriteLine($"{carlot.cars.Count + 2} Quit");

    int choice = 0;
    while (true)
    {
        try
        {
            choice = int.Parse(Console.ReadLine());
            if (choice >= 1 && choice <= carlot.cars.Count + 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("Not a menu option");
            }
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    //buying a car
    if (choice >=1 && choice <= carlot.cars.Count)
    {
        Console.WriteLine(carlot.cars[choice - 1]);
        while (true)
        {
            Console.WriteLine("Would you like to buy the car? y/n");
            string purchase = Console.ReadLine();
            if(purchase.ToLower().Trim() == "y")
            {
                carlot.RemoveCar(choice - 1);
                Console.WriteLine("Great! Our Finance department will be in touch shortly.");
                break;
            }
            else if (purchase.ToLower().Trim() == "n")
            {
                Console.WriteLine("You will regret this.");
                break;
            }
            else
            {
                Console.WriteLine("That was not a valid input");
            }
        }
        
        
    }
    //Adding a car
    else if(choice == carlot.cars.Count + 1)
    {
        Console.WriteLine("Perfect! Please give me more info about that car");
        //make
        Console.WriteLine("What is the car's make?");
        string make = Console.ReadLine();
        //model
        Console.WriteLine("What is the car's model?");
        string model = Console.ReadLine();
        //year
        int year = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("What is the car's year?");
                year = int.Parse(Console.ReadLine());

                break;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //price
        decimal price = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("What is the car's price?");
                price = decimal.Parse(Console.ReadLine());

                break;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //is car used?
        bool isUsed = true;
        while (true)
        {
            Console.WriteLine("Is this car used? y/n");
            string isUsedChoice = Console.ReadLine();
            if(isUsedChoice.ToLower().Trim() == "y")
            {
                isUsed = true;
                break;
            }
            else if (isUsedChoice.ToLower().Trim() == "n")
            {
                isUsed = false;
                break;
            }
            else
            {
                Console.WriteLine("That input was not valid");
            }
        }

        if(isUsed == false)
        {
            Car newCar = new Car(make, model, year, price);
            carlot.AddCar(newCar);
        }
        //used cars
        else
        {
            double mileage = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the mileage?");
                    mileage = double.Parse(Console.ReadLine());

                    break;
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            UsedCar newCar = new UsedCar(make, model, year, price, mileage);
            carlot.AddCar(newCar);
        }

        Console.WriteLine("Thank you for the new car! It will be displayed ASAP");
    }
    //quit
    else if (choice == carlot.cars.Count + 2)
    {
        runProgram = false;
        Console.WriteLine("Thank you for visiting the car shop! It will be reset tomorrow");
    }
}