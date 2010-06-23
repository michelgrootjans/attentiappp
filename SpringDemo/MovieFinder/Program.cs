using System;
using MovieFinder.Utilities;

namespace MovieFinder
{
    public static class Program
    {
        public static void Main()
        {
            try
            {
                var service = IocContainer.GetAnImplementationOf<IMovieService>();
                var movies = service.GetMoviesWith("Kevin Costner");

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