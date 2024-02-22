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
    internal class Movie
    {
        public List<Movie> MovieList { get; set; } = new List<Movie>();

        public Movie(string title, string category)
        {
            MovieList = new List<Movie>();
        }
    }
}