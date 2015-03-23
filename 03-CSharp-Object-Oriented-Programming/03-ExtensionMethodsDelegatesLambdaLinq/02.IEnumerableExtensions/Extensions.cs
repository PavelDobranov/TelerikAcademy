namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    using TypeExtensions;

    public static class Extensions
    {
        private const string InvalidTypeOperationErrorMessageFormat = "Math operators: \'+\', \'-\', \'*\', \'/\', \'%\' cannot be applied to operands of type {0} and {0}";

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            ValidateTypeOperations<T>();

            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();

            dynamic sum = enumerator.Current;

            while (enumerator.MoveNext())
            {
                sum += enumerator.Current;
            }

            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> collection)
        {
            ValidateTypeOperations<T>();

            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();

            dynamic product = enumerator.Current;

            while (enumerator.MoveNext())
            {
                product *= enumerator.Current;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();

            T min = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(min) < 0)
                {
                    min = enumerator.Current;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();

            T max = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(max) > 0)
                {
                    max = enumerator.Current;
                }
            }

            return max;
        }

        public static dynamic Average<T>(this IEnumerable<T> collection)
        {
            ValidateTypeOperations<T>();

            var enumerator = collection.GetEnumerator();
            enumerator.MoveNext();

            dynamic sum = enumerator.Current;

            int count = 1;

            while (enumerator.MoveNext())
            {
                sum += enumerator.Current;
                count++;
            }

            return sum / count;
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        private static void ValidateTypeOperations<T>()
        {
            if (!typeof(T).IsNumeric())
            {
                throw new InvalidOperationException(string.Format(Extensions.InvalidTypeOperationErrorMessageFormat, typeof(T)));
            }
        }
    }
}