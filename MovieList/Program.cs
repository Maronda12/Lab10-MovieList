using System;
using System.Collections.Generic;



namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {


            //Each movie should be represented by an object of type Movie.
            List<Movie> movies = new List<Movie>();

            Movie m1 = new Movie("CHERRY", Genre.Drama);
            movies.Add(m1);

            Movie m2 = new Movie("Pulp Fiction", Genre.Drama);
            movies.Add(m2);

            Movie m3 = new Movie("Training Day", Genre.Drama);
            movies.Add(m3);

            Movie m4 = new Movie("Toy Story", Genre.Animated);
            movies.Add(m4);

            Movie m5 = new Movie("Cars", Genre.Animated);
            movies.Add(m5);


            Movie m6 = new Movie("A Quiet Place", Genre.Horror);
            movies.Add(m6);

            Movie m7 = new Movie("SAW", Genre.Horror);
            movies.Add(m7);

            Movie m8 = new Movie("TENET", Genre.Scifi);
            movies.Add(m8);

            Movie m9 = new Movie("INTERSTELLAR", Genre.Scifi) ;
            movies.Add(m9);

            Movie m10 = new Movie("STAR WARS : The Rise of Skywalker", Genre.Scifi);
            movies.Add(m10);

            Console.WriteLine("Here are the accepted Genres:");


            Genre[] acceptedGenres = (Genre[])Enum.GetValues(typeof(Genre));

            foreach (Genre g in acceptedGenres)
            {
                Console.WriteLine(g);
            }

            Console.WriteLine("Please input a movie genre you wish to search");
            string input = Console.ReadLine();


            Genre inputGenre = (Genre)Enum.Parse(typeof(Genre), input);

            //Any time you do a search think loops
            foreach (Movie m in movies)
            {

                if (m.Genre == inputGenre)
                {
                    Console.WriteLine(m.Genre);
                }

            }





        }
    }   
}