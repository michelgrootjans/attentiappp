namespace Facade.Appliances
{
    internal interface IVideoSource
    {
        void TurnOn();
        string Name { get; }
    }
}