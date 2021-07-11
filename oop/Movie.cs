using System;

namespace oop {
    /// <summary>
    /// A Movie Class
    /// @params title: Title of the movie
    /// @params director: Author of the movie
    /// @params rating: rating of the movie. 
    /// ratings can either be G, PG, PG-13, R, NR.
    /// <code>Movie movie1 = new Movie("Title", "director", 5)</code>
    /// </summary>
    class Movie {
        public string title;
        public string director;
        private string rating;

        public Movie(string title_, string director_, string rating_) {
            Console.WriteLine("Creating Movie...");
            title = title_;
            director = director_;
            Rating = rating_;
        }

        public string Rating { 
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value ==   "R" || value == "NR") {
                    rating = value;
                } else {
                    rating = "NR";
                }
            }
        }
    }
}
