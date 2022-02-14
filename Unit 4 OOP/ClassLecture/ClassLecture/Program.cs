// See https://aka.ms/new-console-template for more information
using ClassLecture;

Console.WriteLine("Hello, World!");


Pen myPen = new Pen("Blue", "Pilot", "Gel", 1.50M, 5);
//myPen.Color = "Blue";
//myPen.Brand = "Pilot";
//myPen.InkType = "Gel";
//myPen.Price = 1.50m;
//myPen.Length = 5;

Console.WriteLine(myPen.Brand);

Pen myPen2 = new Pen("Black", "Bick", "Ballpoint", 0.50M, 5.3f);
//{
//    Color = "Black",
//    Brand = "Bick",
//    InkType = "Ballpoint",
//    Price = 0.50m,
//    Length = 5.3f,
//};

Console.WriteLine(myPen2.Brand);

myPen.Draw();
myPen.Draw();
myPen.Draw();
myPen.Draw();
myPen.Draw();
//out of ink
myPen.Draw();
//Cannot refill. InkLevel is private
//myPen.InkLevel = 5;

myPen2.Draw();
Console.WriteLine(myPen.GetInfo());
Console.WriteLine(myPen2.GetInfo());

List<Pen> CupHolder = new List<Pen>();
CupHolder.Add(myPen);
CupHolder.Add(myPen2);

//Loop through all in list
foreach(Pen p in CupHolder)
{
    p.Draw();
}



Song mySong = new Song()
{
    Name = "Through the Fire and Flames",
    BPM = 200,
    Length = 6.5,
    Rating = 10,
    Artist = "DragonForce"
};
Console.WriteLine(mySong.Name);
mySong.Listen();
Console.WriteLine(mySong.Enjoy());

//Calling static methods
Resturant.FeedCustomer();
//int.Parse() is a static method
int x = int.Parse("1");
