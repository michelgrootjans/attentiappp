using System;
using System.Collections.Generic;

namespace MovieFinder
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository repository;
        private readonly Random random = new Random();

        public MovieService(IMovieRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<IMovie> GetMoviesWith(string actor)
        {
            Console.WriteLine("Executing GetMoviesWith");
            if(random.Next(2) == 1)
                throw new Exception();
            return repository.GetMoviesByActor(actor);
        }
    }
}