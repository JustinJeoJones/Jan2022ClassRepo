// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Pig Latin Translater");

//Loop program
bool runProgram = true;
while (runProgram)
{
    //user input
    string input = "";
    while (true)
    {
        Console.WriteLine("Please enter a word.");
        input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine("Nothing was entered. Try again.");
        }
        else
        {
            break;
        }
    }
    

    //Convert to lowercase (removed for extended)
    //input = input.ToLower();


    //spliting sentence
    string[] words = input.Split(" ");

    //loop through words
    string result = "";
    foreach (string w in words)
    {
        //translating
        result += translate(w) + " ";
    }
    Console.WriteLine(result);

    while (true)
    {
        Console.WriteLine("Would you like to go again? y/n");
        string loopChoice = Console.ReadLine();
        if(loopChoice == "y")
        {
            runProgram = true;
            break;
        }
        else if (loopChoice == "n")
        {
            runProgram=false;
            break;
        }
        else
        {
            Console.WriteLine("That was not a valid input");
        }
    }
}



//methods
static string translate(string word)
{
    if (ContainsSymbols(word) || ContainsNumber(word))
    {
        //stop method early by returning word
        return word;
    }


    //starts with vowel
    if (word.Substring(0,1).ToLower() =="a"|| word.Substring(0, 1).ToLower() == "e" || word.Substring(0, 1).ToLower() == "i" || word.Substring(0, 1).ToLower() == "o"|| word.Substring(0, 1).ToLower() == "u")
    {
        word = word + "way";
    }
    //starts with consonant
    else
    {
        int cCounter = 0;

        //what 1234
        //what 01234

        for(int i = 0; i < word.Length; i++)
        {
            if(word.Substring(i, 1).ToLower() == "a"|| word.Substring(i, 1).ToLower() == "e"|| word.Substring(i, 1).ToLower() == "i"|| word.Substring(i, 1).ToLower() == "o" || word.Substring(i, 1).ToLower() == "u")
            {
                //what

                //wh
                string temp = word.Substring(0, cCounter);

                //atwhay
                word = word.Substring(cCounter) + temp + "ay";
                //stop loop to prevent more changes
                break;
            }
            else
            {
                cCounter++;
            }
        }
    }

    //return result
    return word;
}

//no Symbols
static bool ContainsSymbols(string word)
{
    for(int i =0; i < word.Length; i++)
    {
        if(word.Substring(i,1) == "@" || word.Substring(i, 1) == "." || word.Substring(i, 1) == "-" || word.Substring(i, 1) == "," || word.Substring(i, 1) == "$" || word.Substring(i, 1) == "^" || word.Substring(i, 1) == "&")
        {
            return true;
        }
    }
    //no symbol within loop
    return false;
}

static bool ContainsNumber(string word)
{
    //foreach(char c in word)
    //{
    //    if(c < '0' || c > '9')
    //    {
    //        return true;
    //    }
    //}
    //return false;
    return word.All(char.IsDigit);
}