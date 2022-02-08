List<int> numbers = new List<int>()
{
    5,
    3,
    6,
    4,
    11,
    12
};

//old way
int counter = 0;
foreach(int num in numbers)
{
    if(num % 2 == 0)
    {
        counter++;
    }
}
Console.WriteLine(counter);
//Linq (Method syntax)
int evenNumbers = numbers.Count(n => n%2 == 0);
Console.WriteLine(evenNumbers);

//Query Expression
int evenNumbersQuery = (from n in numbers
                       where n % 2 == 0
                       select n).ToList().Count;
Console.WriteLine(evenNumbersQuery);

//more examples
List<int> ages = new List<int>()
{
    10,
    20,
    30,
    21,
    15,
    19,
    23,
    60,
    100
};

//Where
//Its a filter
List<int> agesAdult = ages.Where(a => a >= 21).ToList();

//Foreach
//loops through all elements
agesAdult.ForEach(a => Console.WriteLine(a));

Console.WriteLine();
//First
//First returns back the first matching element
int first21 = ages.First(a => a >= 21);
Console.WriteLine(first21);

Console.WriteLine();
//any
//returns a true/false if any elements match
bool over50Check = ages.Any(a => a > 50);
Console.WriteLine(over50Check);

Console.WriteLine();
//Average
double avgAge = ages.Where(a=> a < 21).Average();
Console.WriteLine(avgAge);

Console.WriteLine();
//Sum
double sumAge = ages.Where(a => a < 21).Sum();
Console.WriteLine(sumAge);

