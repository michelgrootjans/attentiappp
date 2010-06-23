using System;
using Spring.Context;
using Spring.Context.Support;

namespace MovieFinder.Utilities
{
    public static class IocContainer
    {
        private static readonly IApplicationContext context;

        static IocContainer()
        {
            context = ContextRegistry.GetContext();
        }

        public static T GetAnImplementationOf<T>()
        {
            var dictionaryOfImplementations = context.GetObjectsOfType(typeof (T));
            if (dictionaryOfImplementations.Count == 1)
            {
                return dictionaryOfImplementations.FirstValueOf<T>();
            }
            throw new ArgumentException(string.Format("Found {0} implementations of '{1}' in the IOC Container",
                                                      dictionaryOfImplementations.Count, typeof (T).Name));
        }
    }
}