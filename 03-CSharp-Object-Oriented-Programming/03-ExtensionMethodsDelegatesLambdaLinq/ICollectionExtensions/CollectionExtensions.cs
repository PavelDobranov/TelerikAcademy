namespace CollectionExtensions
{
    using System;
    using System.Collections.Generic;

    public static class ICollectionExtensions
    {
        public static void ForEach<T>(this ICollection<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}