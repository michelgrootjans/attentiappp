using System.Collections.Generic;

namespace MovieFinder
{
    public class MovieRepository : IMovieRepository
    {
        public IEnumerable<IMovie> GetMoviesByActor(string actor)
        {
            return new List<IMovie>
                       {
                           new Movie("Dances with wolves"),
                           new Movie("Mr. Brooks"),
                           new Movie("Waterwold"),
                           new Movie("Robin Hood"),
                           new Movie("The Bodyguard")
                       };
        }
    }
}