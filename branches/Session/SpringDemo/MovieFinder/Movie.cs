namespace MovieFinder
{
    public class Movie
    {
        public string Title { get; private set; }

        public Movie(string title)
        {
            Title = title;
        }
    }
}