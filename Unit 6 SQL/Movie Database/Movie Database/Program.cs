// See https://aka.ms/new-console-template for more information
using Movie_Database;

using(MovieDBContext context = new MovieDBContext())
{
    if(context.Movies.Count() == 0)
    {
        FillDB();
    }
}

Console.WriteLine("Welcome to the MovieDB");


Console.WriteLine("Would you like to search by Genre or Title?");
string choice = Console.ReadLine();

List<Movie> results = null;
if(choice == "Genre")
{
    Console.WriteLine("Please enter a genre");
    string genreChoice = Console.ReadLine();
    results = SearchByGenre(genreChoice);
}
else if(choice == "Title")
{
    Console.WriteLine("Please enter a title");
    string titleChoice = Console.ReadLine();
    results = SearchByTitle(titleChoice);
}

foreach(Movie m in results)
{
    Console.WriteLine($"{m.Title} {m.Genre} {m.Runtime} minutes");
}










static List<Movie> SearchByGenre(string genre)
{
    List<Movie> result = null;

    using(MovieDBContext context = new MovieDBContext())
    {
        result = context.Movies.Where(m => m.Genre == genre).ToList();
    }

    return result;
}

static List<Movie> SearchByTitle(string title)
{
    List <Movie> result = null;

    using(MovieDBContext context = new MovieDBContext())
    {
        result = context.Movies.Where(m => m.Title == title).ToList();
    }

    return result;
}

static void FillDB()
{
    using(MovieDBContext context = new MovieDBContext())
    {
        List<Movie> movies = new List<Movie>()
        {
            new Movie(){ Title = "End Game", Genre = "Action", Runtime = 180},
            new Movie(){ Title = "Face Off", Genre= "Action", Runtime = 138},
            new Movie(){ Title= "Lion King", Genre = "Animation", Runtime = 119},
            new Movie(){ Title = "Velocipastor", Genre = "Horror", Runtime = 75},
            new Movie(){Title = "Con Air",Genre = "Action",Runtime = 123 },
            new Movie(){ Title ="The Notebook", Genre = "Romance", Runtime=124 },
            new Movie(){Title= "The Fault in Our Stars", Genre= "Romance", Runtime= 126},
            new Movie(){Title="Spiderman No Way Home", Genre="Action", Runtime= 148},
            new Movie(){Title="Spiderman 3", Genre="Action", Runtime = 139},
            new Movie(){Title = "Monty Python and the Meaning of Life",Genre = "Comedy",Runtime = 107},
            new Movie(){Title = "Star Wars",Genre = "Sci-fi",Runtime = 121 }
        };

        context.Movies.AddRange(movies);
        context.SaveChanges();
    }
}