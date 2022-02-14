using InheritenceLecture;

//savings
SavingsAccount myAccount = new SavingsAccount(1,5, "Justin Bezos", "123 Money street",1.50);
Console.WriteLine(myAccount.Balance);
myAccount.Deposit(100);
Console.WriteLine(myAccount.Balance);
myAccount.Withdraw(100000);
myAccount.Withdraw(105);
Console.WriteLine(myAccount.Balance);

Console.WriteLine();

//checkings
CheckingsAccount myCheckings = new CheckingsAccount(2, 20, "Justin Bezos", "123 Money street", 100);
Console.WriteLine(myCheckings.Balance);
myCheckings.Deposit(80); 
Console.WriteLine(myCheckings.Balance);
myCheckings.Withdraw(100000);
Console.WriteLine(myCheckings.Balance);

Console.WriteLine();

//PolyMorphism in methods
myAccount.Balance = 100;
Console.WriteLine(myAccount.Balance);
myAccount = (SavingsAccount)DeductFee(myAccount);
Console.WriteLine(myAccount.Balance);

myCheckings.Balance = 100;
Console.WriteLine(myCheckings.Balance);
myCheckings = (CheckingsAccount)DeductFee(myCheckings);
Console.WriteLine(myCheckings.Balance);

//Dog
Dog Spot = new Dog("Spot", 1.5 , 15, 4, "A cozy house", 2);
Spot.Eat();
Spot.Speak();
Spot.Move();
Console.WriteLine(Spot.ToString());

//polymorphism in collections
List<Animal> zoo = new List<Animal>()
{
    Spot,
    new Penguin("Rubber", 1.5, 19, 3, "Ice", false),
    new Dog("Baja Blast", 1 , 6 ,1, "Purse", 3)
};
Console.WriteLine();

foreach(Animal a in zoo)
{
    Console.WriteLine(a.ToString());
    a.Move();
    a.Speak();
    a.Eat();
}


//Methods
static BankAccount DeductFee(BankAccount acc)
{
    acc.Withdraw(25);
    return acc;
}