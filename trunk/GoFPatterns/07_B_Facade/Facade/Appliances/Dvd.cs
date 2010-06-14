namespace Facade.Appliances
{
    internal class Dvd : IMovie
    {
        public string Name { get; private set; }

        public Dvd(string name)
        {
            Name = name;
        }
    }
}