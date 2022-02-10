using System.Collections;
//Generics
//Lists
List<int> nums = new List<int>();
nums.Add(5);
nums.Add(14);
nums.Insert(0, 961);
//Strongly typed. Must match data types
//nums.Add("Egg");
foreach(int i in nums)
{
    Console.WriteLine(i);
}
Console.WriteLine($"There are {nums.Count} elements in the list");

//list syntax is the same as array
nums[0] = 1;
int x = nums[0];
Console.WriteLine(nums[0]);
Console.WriteLine(x);

//Dictionary
Dictionary<string, bool> tasty = new Dictionary<string, bool>();
tasty.Add("Chicken Curry", true);
tasty.Add("Asparagus", false);
Console.WriteLine(tasty["Asparagus"]);

foreach(KeyValuePair<string, bool> kvp in tasty)
{
    if(kvp.Value == true)
    {
        Console.WriteLine($"{kvp.Key} is tasty!");
    }
    else
    {
        Console.WriteLine($"{kvp.Key} is icky!");
    }
}



//--------------------------------------------------------------
//DO NOT USE
//JUSTIN WILL FIGHT YOU
// >:(
//Non-Generics

//Array List


ArrayList numbers = new ArrayList();
numbers.Add(5);
numbers.Add(10);
//Allowed, but breaks code. No protections
//numbers.Add("Justin");

numbers.Insert(0, 961);
foreach(int i in numbers)
{
    Console.WriteLine(i);
}
Console.WriteLine($"Arraylist contains {numbers.Count} elements");

//Hashtable
Hashtable ht = new Hashtable();
ht.Add("Joes Smoes", "123-456-7890");
ht.Add("Bobs Pizza", "987-654-3210");
//Allowed, but breaks code. No protections
//ht.Add("Sussiez Pizza", 123-512-9316);

Console.WriteLine(ht["Joes Smoes"]);
//Console.WriteLine(ht["Sussiez Pizza"]);


//------------------------------------------------------------------------
//Exercises

//EXERCISE 47
bool run = true;
List<string> ex47 = new List<string>();
while (run)
{
    Console.WriteLine("Enter some text");
    string input = Console.ReadLine();
    ex47.Add(input);
    string result = "";
    foreach(string word in ex47)
    {
        result += word + " ";
    }
    Console.WriteLine(result);
    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if(choice == "y")
        {
            run = true;
            break;
        }
        else if(choice == "n")
        {
            run = false;
            break;
        }
        else
        {
            Console.WriteLine("Not valid");
        }
    }

}

//Exercise 48
List<int> ex48 = new List<int>();
while (true)
{
    Console.WriteLine("Enter a number (q to quit)");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else
    {
        int result = int.Parse(input);
        ex48.Add(result);
    }
}
int total = 0;
foreach(int num in ex48)
{
    total += num;
    Console.Write($"{num} +");
}
Console.Write($"= {total}");

//Exercise 51
Dictionary<string, string> ex51 = new Dictionary<string, string>();
ex51.Add("hello", "hola");
ex51.Add("food", "comida");
ex51.Add("world", "mundo");
ex51.Add("computer", "computadora");
ex51.Add("exercise", "ejercicio");

Console.WriteLine("Enter a word in english");
string translate = Console.ReadLine();

if (ex51.ContainsKey(translate))
{
    Console.WriteLine(ex51[translate]);
}
else
{
    Console.WriteLine($"{translate} is not a valid key");
}

