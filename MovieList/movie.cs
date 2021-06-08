using System;
namespace MovieList
{
    class Movie
    {
        //The Movie class must provide two private fields: title and category and the
        //properties that go with them.


        public string Title { get; set; }
        public string Category { get; set; }

        
           

        //The class should also provide a constructor that accepts a title and category
        // as parameters and uses the values passed to it to initialize its fields.
        

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;

        }

        
        

    }

}