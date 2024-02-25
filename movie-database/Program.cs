/* Movie Database
 * Mattie Darden
 * 2.15.24 */

using movie_database;
using System.Reflection;

string continueInput = "default";


//List<Movie> storing 10 movies with a mixture of categories
List<Movie> movieList = new List<Movie>()
{
    new Movie("Star Wars", "scifi"),
    new Movie("The Godfather", "drama"),
    new Movie("Psycho", "horror"),
    new Movie("Toy Story", "animated"),
    new Movie("Jurassic Park", "scifi"),
    new Movie("Forrest Gump", "drama"),
    new Movie("The Shining", "horror"),
    new Movie("Finding Nemo", "animated"),
    new Movie("Interstellar", "scifi"),
    new Movie("Titanic", "drama")
};

//Starting application
Console.WriteLine("Welcome to the Movie List Database!");
Console.WriteLine("There are 15 movies in this list");
// Display the available categories
Console.WriteLine("Categories: animated, drama, horror, scifi");

while (true)
{
    Console.WriteLine("What category are you intered in?");
    string category = Console.ReadLine().ToLower().Trim();
    
    // Check if the category is valid
    if (category.ToLower().Trim() == "animated" || category == "drama" || category == "horror" || category == "scifi")
    {
        Console.WriteLine($"Movies in the {category} category:");

        var categoryList = movieList.Where(movie => movie.Category == category);

        foreach (var Movie in categoryList)
        {
            Console.WriteLine(Movie.Title);
        }
    }
    else
    {
        Console.WriteLine("Invalid category! Please enter a valid category.");
        continue; // Restart the loop to ask for the category again
    }

    // Ask if the user wants to continue
    Console.WriteLine("Continue? (y/n): ");
    continueInput = Console.ReadLine().ToLower();
  
    if (continueInput != "y")
    {
        break; // Exit the loop and end the program
    }
}

Console.WriteLine("Thanks for using the Movie Database Application");