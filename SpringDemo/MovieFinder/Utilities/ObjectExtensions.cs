namespace MovieFinder.Utilities
{
    public static class ObjectExtensions
    {
        public static T As<T>(this object target)
        {
            if (target is T) 
                return (T) target;
            return default(T);
        }
    }
}