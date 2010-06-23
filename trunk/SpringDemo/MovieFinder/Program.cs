using System;

namespace MovieFinder
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var service = new MovieService();
                var movies = service.GetMovieWith("Kevin Costner");

                Console.WriteLine("Movies by Kevin Costner:");
                foreach (var movie in movies)
                {
                    Console.WriteLine("- " + movie.Title);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}