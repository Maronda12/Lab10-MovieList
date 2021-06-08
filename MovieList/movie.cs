using System;

namespace MovieList
{
    public enum Genre
    {
        Animated,
        Drama,
        Horror,
        Scifi,
        
    }

    class Movie
    {


        public string Movies { get; set; }

        public Genre Genre { get; set; }


        public Movie(string title, in Genre genre)
        {
            string movies = Movies;
            Movies = movies;
            this.Genre = Genre;
        }
    }
}