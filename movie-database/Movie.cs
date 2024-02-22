using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Build a movie class with two member variables (strings): title and category.
namespace movie_database
{
    public class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }

        public List<Movie> MovieList { get; set; } = new List<Movie>();
        //constructors
        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
            MovieList = new List<Movie> ();
        }
        
    }
}
