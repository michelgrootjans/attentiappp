using System.Collections.Generic;

namespace MovieFinder
{
    internal class MovieRepository
    {
        public List<Movie> GetMoviesByActor(string actor)
        {
            return new List<Movie>
                       {
                           new Movie("Dances with wolves"),
                           new Movie("Mr. Brooks")
                       };
        }
    }
}