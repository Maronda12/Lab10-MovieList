using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            while (again == true)

            {

                //Each movie should be represented by an object of type Movie.
                List<Movie> MovieList = new List<Movie>();

                MovieList.Add(new Movie("CHERRY", "Drama"));
                MovieList.Add(new Movie("Pulp Fiction", "Drama"));
                MovieList.Add(new Movie("Training Day", "Drama"));
                MovieList.Add(new Movie("Toy Story", "Animated"));
                MovieList.Add(new Movie("Cars", "Animated"));
                MovieList.Add(new Movie("A Quiet Place", "Horror"));
                MovieList.Add(new Movie("SAW", "Horror"));
                MovieList.Add(new Movie("TENET", "Sci-Fi"));
                MovieList.Add(new Movie("INTERSTELLAR", "Sci-Fi"));
                MovieList.Add(new Movie("STAR WARS : The Rise of Skywalker", "Sci-Fi"));
                //Sorts List 
                var moviesOrder = MovieList.OrderBy(s => s.Title);



                Console.WriteLine("Please select a movie genre: Drama, Animated, Horror, Sci-Fi");
                string genre = Console.ReadLine().ToLower();

                //Suppose to Return Movie Titles but does not work.
                foreach (Movie m in moviesOrder)
                {
                    if (m.Category == " ")
                    {
                        
                        Console.WriteLine(m.Category);
                    }
                    if (genre == " ")
                    {
                        Console.WriteLine("Invalid input. Please try again");

                    }
                    Console.WriteLine();
                    
                }
            }
        }
        // Gets User Input Function
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();

            if (input == "drama" || input == "animated" || input == "horror" || input == "sci-fi")
            {
                return input;
            }
            else
            {
                string noInput = "Please try again";
                return GetUserInput(noInput);


            }
        }

        public static bool PickAgain()
        {
            Console.WriteLine("Would you like to choose more movies? yes or no");
            string input = Console.ReadLine().ToLower();

            if (input == "yes" || input == "y")
            {
                Console.WriteLine("Great!");
                return true;
            }
            else 
            {
                Console.WriteLine("Goodbye");
                return false;
            }
        }
    }   
}