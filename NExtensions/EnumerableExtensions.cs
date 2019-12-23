using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace NExtensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty(this IEnumerable collection)
        {
            if(collection == null)
            {
                return true;
            }

            IEnumerator enumerator = collection.GetEnumerator();
            return enumerator?.Current == null;
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }

        public static bool IsNotNullOrEmptyEmpty<T>(this IEnumerable<T> collection)
        {
            return !collection.IsNullOrEmpty();
        }
    }
}
