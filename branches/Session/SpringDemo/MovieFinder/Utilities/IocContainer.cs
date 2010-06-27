using System;
using Spring.Context;
using Spring.Context.Support;

namespace MovieFinder.Utilities
{
    /// <summary>
    /// This is a Spring.net implementation of an IoC container. This is the oldest of IoC/AoP frameworks
    /// for .net. I still use it because it's the one I know best. http://www.springframework.net/
    /// 
    /// Other alternatives are, in no particular order:
    /// - LinFu: http://code.google.com/p/linfu/
    /// - Castle windsor: http://www.castleproject.org/container/index.html
    /// - Ninject: http://ninject.org/
    /// - StructureMap: http://structuremap.github.com/structuremap/
    /// 
    /// Pick whatever you prefer.
    /// </summary>
    public static class IocContainer
    {
        private static readonly IApplicationContext context;

        static IocContainer()
        {
            //read configuration from app config
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