using System.Collections.Generic;

namespace MovieFinder
{
    class MovieService
    {
        public List<Movie> GetMovieWith(string actor)
        {
            var repository = new MovieRepository();
            return repository.GetMoviesByActor(actor);
        }
    }
}