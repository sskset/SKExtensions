using System;

namespace NExtensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return true;
            }

            return source.Length == 0;
        }

        public static bool IsNotNullOrEmpty(this string source)
        {
            return !source.IsNullOrEmpty();
        }
    }
}
