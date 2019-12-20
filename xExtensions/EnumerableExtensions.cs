using System;
using System.Collections.Generic;
using System.Linq;

namespace xExtensions
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            return !IsNotEmpty(collection);
        }

        public static bool IsNotEmpty<T>(this IEnumerable<T> collection)
        {
            return collection != null && collection.Any();
        }
    }
}
