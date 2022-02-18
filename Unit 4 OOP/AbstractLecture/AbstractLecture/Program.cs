using AbstractLecture;

//ABSTRACT
//Cannot create instance of abstract class
//BankAccount myBank = new BankAccount();

CheckingsAccount myCheckings = new CheckingsAccount(100, "Justin", 75);

Console.WriteLine(myCheckings.Balance);
myCheckings.Deposit(1);
Console.WriteLine(myCheckings.Balance);
myCheckings.Withdraw(1);
Console.WriteLine(myCheckings.Balance);
myCheckings.Withdraw(200);
Console.WriteLine(myCheckings.Balance);

Console.WriteLine();

SavingsAccount mySavings = new SavingsAccount(100, "Justin");

Console.WriteLine(mySavings.Balance);
mySavings.Deposit(1);
Console.WriteLine(mySavings.Balance);
mySavings.Withdraw(1);
Console.WriteLine(mySavings.Balance);
mySavings.Withdraw(200);
Console.WriteLine(mySavings.Balance);

WinLottery(mySavings);

List<BankAccount> bankAccounts = new List<BankAccount>();
bankAccounts.Add(myCheckings);
bankAccounts.Add(mySavings);

Console.WriteLine();

//INTERFACES
//Cannot create instance of Interface
//IAnimal myAnimal = new IAnimal();

Cat Max = new Cat("Max", 10);
Max.Move();
Max.Eat();
Max.Speak();
Console.WriteLine(Max.GetHunger());
DisplayAnimal(Max);

Console.WriteLine();

Turtle Jeff = new Turtle("Jeff", 2);
DisplayAnimal(Jeff);


List<IAnimal> zoo = new List<IAnimal>();
zoo.Add(Max);
zoo.Add(Jeff);


//Method
static void WinLottery(BankAccount account)
{
    account.Deposit(900000);
}

static void DisplayAnimal(IAnimal a)
{
    a.Move();
    a.Speak();
    a.Eat();
    Console.WriteLine(a.GetHunger());
}