using System.Collections.Generic;

namespace MovieFinder
{
    public interface IMovieRepository
    {
        IEnumerable<IMovie> GetMoviesByActor(string actor);
    }
}