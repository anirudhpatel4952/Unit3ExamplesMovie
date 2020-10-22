using System;
using System.Collections.Generic;

namespace classPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie firstMovie = new Movie("Interstellar", "Christopher Nolan", 2014, "123abc", new List<float> { });

            Console.WriteLine($"Please provide your rating to Movie : {firstMovie.MovieName}");

            firstMovie.RatingInput(firstMovie);

            firstMovie.PrintList();


        }

        
    }

   

    
}
