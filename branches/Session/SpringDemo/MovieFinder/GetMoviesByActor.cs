using System.Collections.Generic;

namespace MovieFinder
{
    public class GetMoviesByActor : IQuery<IMovie>
    {
        private readonly string actor;

        public GetMoviesByActor(string actor)
        {
            this.actor = actor;
        }

        public IEnumerable<IMovie> Execute(ISession session)
        {
            yield return new Movie("Dances with wolves");
            yield return new Movie("Waterwolrd");
        }
    }
}