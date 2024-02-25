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
        public string Title { get; set; }
        public string Category{ get; set; }

        public Movie(string title, string category)
        {
           this.Title = title;
           this.Category = category;
        }

    }
}