using System;
using System.Collections.Generic;

namespace classPractice
{
    public class Movie
    {
        //constructor
        public Movie(string MovieNameArgument, string DirectorArgument, int YearArgument, string UniqueIdArgument, List<float> MovieRatingsArgument) {
            MovieName = MovieNameArgument;
            Director = DirectorArgument;
            Year = YearArgument;
            UniqueId = UniqueIdArgument;
            MovieRatings = MovieRatingsArgument;

        }
        //data member/properties
        public string MovieName { get; set; }
        public string Director { get; set; }

        public int Year { get; set; }
        public string UniqueId { get; set; }
        public List<float> MovieRatings { get; private set; }
        

        //methods
        public void RatingInput(Movie firstMovie)
        {
            float rate = 0;
            var num = 3;
            for (int i = 0; i < num; i++)
            {
                rate = Convert.ToInt32(Console.ReadLine());
                if (rate < 1 || rate > 5){
                    num += 1;
                    
                }
                RateMovie(rate);
                
            }
        }
        public void RateMovie(float rating) {
            
                if (rating >=1 && rating <= 5) {
                    MovieRatings.Add(rating);
                    Console.WriteLine($"Rating you provided is {rating}\n");
                }
                else {
                    Console.WriteLine($"Please add a valid rating : 1 to 5");
                
                }
            }
            
        
        public float GetAverageRating(List<float> MovieRatings) {
            float result = 0;
            float average = 0;
            for (int i = 0; i < MovieRatings.Count; i++) {
                
                result += MovieRatings[i];
                
            }
            average = result /  MovieRatings.Count;
            Math.Round(average, 1);
            return average;
        }
        
        public void PrintList() {
            Console.WriteLine($"Information available:\n");
            Console.WriteLine($"Name of the Movie : {MovieName}\nDirector : {Director}\nYear of Release : {Year}");
            Console.WriteLine($"The average rating of {MovieName} is : {Math.Round(GetAverageRating(MovieRatings), 1)}");
        }
    }

   

    
}
