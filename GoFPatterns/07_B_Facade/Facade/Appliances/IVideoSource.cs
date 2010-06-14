namespace Facade.Appliances
{
    internal interface IVideoSource
    {
        void TurnOn();
        void Play(IMovie movie);
        string Name { get; }
    }
}