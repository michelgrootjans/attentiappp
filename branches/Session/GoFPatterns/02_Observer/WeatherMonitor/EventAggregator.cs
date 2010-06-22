using System.Collections.Generic;

namespace WeatherMonitor
{
    public static class EventAggregator
    {
        private static readonly List<object> listeners = new List<object>();

        public static void Register(object listener)
        {
            listeners.Add(listener);
        }

        public static void Raise<T>(T domainEvent) where T : IDomainEvent
        {
            foreach (var listener in listeners)
            {
                if (typeof (IEventHandler<T>).IsAssignableFrom(listener.GetType()))
                {
                    var typedListener = (IEventHandler<T>) listener;
                    typedListener.Handle(domainEvent);
                }
            }
        }
    }

    public interface IEventHandler<T> where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }

    public interface IDomainEvent
    {
    }
}