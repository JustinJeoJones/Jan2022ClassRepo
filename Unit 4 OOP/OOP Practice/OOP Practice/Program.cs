using OOP_Practice;

List<Customer> customers = new List<Customer>()
{
    new Customer(3),
    new Customer(5),
    new Customer(10),
    new Customer(25),
};

Store myStore = new Store(10, customers);

Console.WriteLine(myStore.runStore());