using System.Collections.Generic;

namespace MovieFinder
{
    public interface IMovieService
    {
        IEnumerable<IMovie> GetMoviesWith(string actor);
    }
}