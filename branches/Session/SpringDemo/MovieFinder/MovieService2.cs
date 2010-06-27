using System;
using System.Collections.Generic;

namespace MovieFinder
{
    public class MovieService : IMovieService
    {
        private readonly IRepository repository;
        private readonly Random random = new Random();

        public MovieService(IRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<IMovie> GetMoviesWith(string actor)
        {
            Console.WriteLine("Executing MovieService.GetMoviesWith(...)");
            if(random.Next(2) == 1)
                throw new Exception();
            return repository.Query(new GetMoviesByActor(actor));
        }
    }
}