namespace MovieFinder
{
    public class Movie : IMovie
    {
        public string Title { get; private set; }

        public Movie(string title)
        {
            Title = title;
        }
    }
}