// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


//Creating strings
string myString = "grand circus";
char[] charArray = { 'G', 'r', 'a', 'n', 'd', ' ', 'C', 'i', 'r' ,'c', 'u', 's' };
string myString2 = new string(charArray);

Console.WriteLine(myString);
Console.WriteLine(myString2);

//Joining strings
string myString3 = myString + myString2;
string myString4 = string.Concat(myString, myString2);

Console.WriteLine(myString3);
Console.WriteLine(myString4);

//Comparing strings
if(myString == myString2)
{
    Console.WriteLine("String 1 and 2 are equal");
}

if("Hi" == "hi")
{
    Console.WriteLine("Hi is equal to hi");
}
else
{
    Console.WriteLine("Hi is not equal to hi");
}
//add ,true to ignore casing
//string.Compare(myString, myString2, true)
if (string.Compare(myString, myString2) == 0)
{
    Console.WriteLine("String 1 and 2 are equal");
}

if (myString.Equals(myString2))
{
    Console.WriteLine("String 1 and 2 are equal");
}

//string methods
//Indexof

Console.WriteLine(myString.IndexOf(" "));

//LastIndexOf
Console.WriteLine(myString3.LastIndexOf(" "));

//EndsWith
Console.WriteLine(myString3.EndsWith("cus"));

//Replace
Console.WriteLine(myString3.Replace(' ', '_'));

//Split
string[] gcSplit = myString.Split(" ");
foreach(string x in gcSplit)
{
    Console.WriteLine(x);
}

//Substring
Console.WriteLine(myString.Substring(4));

//ToUpper
Console.WriteLine(myString.ToUpper());

//ToLower
Console.WriteLine(myString2.ToLower());

//Trim
string messy = "              hsdjkflhdsaljk           ";
Console.WriteLine("/" + messy + "/");
Console.WriteLine("/" + messy.Trim() + "/");


//String Builder
StringBuilder strBuff = new StringBuilder("test!");
strBuff.Append("\t Super!");
Console.WriteLine(strBuff);