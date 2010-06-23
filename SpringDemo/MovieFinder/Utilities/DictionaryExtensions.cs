using System.Collections;
using System.Linq;

namespace MovieFinder.Utilities
{
    public static class DictionaryExtensions
    {
        public static T FirstValueOf<T>(this IDictionary target)
        {
            return (T) target.Values
                           .Cast<object>()
                           .Where(value
                               => typeof (T).IsAssignableFrom(value.GetType()))
                           .FirstOrDefault();
        }
    }
}