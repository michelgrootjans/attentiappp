namespace KataTests.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object target)
        {
            return target == null;
        }

        public static bool IsNullOrEmpty(this string target)
        {
            return string.IsNullOrEmpty(target);
        }
    }
}