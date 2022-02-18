using MovieDatabase;

List<Movie> movies = new List<Movie>()
{
    new Movie("Superbad", "Comedy", 119),
    new Movie("Spider-Man: Into the Spider-Verse", "Animated", 114),
    new Movie("The Lion King", "Animated", 89),
    new Movie("X-Men", "Action", 104),
    new Movie("Infinity War", "Action", 149),
    new Movie("Insidious", "Horror", 103),
    new Movie("The Conjuring", "Horror", 118),
    new Movie("Kramer Vs Kramer", "Drama", 105),
    new Movie("Atonement", "Drama", 123),
    new Movie("StarWars", "Scifi", 121),
    new Movie("Notebook", "Romance", 121)
};

//get distinct categorys
List<Movie> distinctCategories = movies.GroupBy(m => m.Category).Select(g => g.First()).ToList();

Console.WriteLine("Welcome to the GC Theater");
Console.WriteLine($"There are {movies.Count} movies in this list.");

//Loop program
bool runProgram = true;
while (runProgram)
{
    //User input
    Console.WriteLine("What category are you interested in?");
    for(int i = 0; i< distinctCategories.Count; i++)
    {
        Console.WriteLine($"{i}. {distinctCategories[i].Category}");
    }

    int num = 0;
    while(true)
    {
        try
        {
            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num < distinctCategories.Count)
            {
                break;
            }
            else
            {
                Console.WriteLine("Not a valid number chocie");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    string category = distinctCategories[num].Category;
    
    //getting matches
    List<Movie> result = movies.Where(m => m.Category.ToLower() == category.ToLower()).ToList();

    //List<Movie> result = new List<Movie>();
    //foreach(Movie m in movies)
    //{
    //    if(m.Category.ToLower() == category.ToLower())
    //    {
    //        result.Add(m);
    //    }
    //}

    //Display Matches
    foreach (Movie m in result.OrderBy(m => m.Title))
    {
        Console.WriteLine($"{m.Title} RUNTIME: {m.RunTime}");
    }

    if(result.Count == 0)
    {
        Console.WriteLine("That category does not exist");
    }

    //Ask if continue
    while (true)
    {
        Console.WriteLine("Would you like to search again? y/n");
        string choice = Console.ReadLine();
        if(choice.ToLower() == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice.ToLower() == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not valid");
        }
    }
}
