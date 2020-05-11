using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homeworks09.Task1
{
   public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie (string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            try
            {
                    if (rating < 1 || rating > 5)
                {
                    Exception ratingException = new Exception("You entered wrong rating! Please enter rating from 1-5:");
                    throw ratingException;
                }
                    else
                    {
                        Rating = rating;
                    }
                }
            
            catch (Exception ex)
            {
                while (true)
                {
                    Console.WriteLine($"{ex.Message}");
                    string secondTry = Console.ReadLine();
                    bool isValid = int.TryParse(secondTry, out rating);
                    if (isValid && rating >= 1 && rating <=5)
                    {
                        Rating = rating;
                        break;
                    }
                }
            }
            
            TicketPrice = 5 * Rating;
        }
    }
}
