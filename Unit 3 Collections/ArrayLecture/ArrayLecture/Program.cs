//Instantianting Arrays
string[] titles = new string[4];

double[] prices;
prices = new double[4];

int titleCount = 100;
string[] titles2 = new string[titleCount];

Console.WriteLine("How big do you want the array");
string input = Console.ReadLine();
int titleCount2 = int.Parse(input);
string[] titles3 = new string[titleCount2];

string[] names = { "Lucas", "Justin", "Tarik", "Aaliyah", "Jon", "Alex", "Josh" };

//Accessing Array Elements
Console.WriteLine(titles[0]);
Console.WriteLine(names[1]);

titles[0] = "Interstellar";
titles[1] = "Blade Runner";
titles[2] = "Star Wars";
titles[3] = "Super Bad";

//titles[0] = "Velicopastor";

Console.WriteLine(titles[0]);

//Loop through arrays
//for loop
for(int i = 0; i < titles.Length; i++)
{
    Console.WriteLine(titles[i]);
}
//foreach
foreach(string name in names)
{
    Console.WriteLine(name);
}

//average price challenge
double[] storePrices = { 2.99, 2.46, 5.50, 1.99, 1.69, 1.49, 2.71 };

//get average using for loop
double sum = 0;
for(int i = 0; i < storePrices.Length; i++)
{
    sum += storePrices[i];
}
double average = sum / storePrices.Length;
Console.WriteLine(average);
//foreach
double total = 0;
foreach(double P in storePrices)
{
    total += P;
}
double avg = total / storePrices.Length;
Console.WriteLine(avg);

//Built in array methods
Console.WriteLine();
Array.ForEach(storePrices, (double x) =>
{
    Console.WriteLine(x);
});

Array.Reverse(storePrices);
Console.WriteLine();
//foreach to prove it reverses
Array.ForEach(storePrices, (double x) =>
{
    Console.WriteLine(x);
});
Console.WriteLine();

//Sort from lowest to highest
Array.Sort(storePrices);
Array.ForEach(storePrices, (double x) =>
{
    Console.WriteLine(x);
});
Console.WriteLine();

//If array contains
if (storePrices.Contains(5.50))
{
    Console.WriteLine("You have an item at the selected price");

    //Find index of item
    //int i = storePrices.IndexOf(5.50);
    int i = Array.IndexOf(storePrices, 5.50);
    Console.WriteLine($"it is at index {i}");

}

double max = storePrices.Max();
Console.WriteLine(max);
double min = storePrices.Min();
Console.WriteLine(min);

//using methods
DisplayAll(names);
string[] myArray = CreateArray(10);
DisplayAll(myArray);
myArray = ReplaceArray(myArray, "Hi");
DisplayAll(myArray);


//Methods
//Display all
//take in string array as param
//display all strings
//dont return anything

static void DisplayAll(string[] values)
{
    foreach(string value in values)
    {
        Console.WriteLine(value);
    }
}

//Create Array
//1 paramater int length
//Make a string array that is the size of length
//return back the new string array

static string[] CreateArray(int length)
{
    return new string[length];
}

//Replace Array
//2 params. 1 string array 2 string
//in the string array, replace all elements with string parameter
//return the array

static string[] ReplaceArray(string[] values, string replace)
{
    for(int i = 0; i < values.Length; i++)
    {
        values[i] = replace;
    }
    return values;
}