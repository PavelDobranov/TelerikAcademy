namespace StringBuilderExtensions
{
    using System;
    using System.Text;

    public static class Extensions
    {
        private const string IndexOutOfRangeErrorMessage = "Index was out of range. Must be non-negative and less than the size of the collection.";
        private const string LengthOutOfRangeErrorMessage = "Length must refer to a location within the collection.";

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (index < 0 || index >= sb.Length)
            {
                throw new IndexOutOfRangeException(Extensions.IndexOutOfRangeErrorMessage);
            }

            if (length < 0 || index + length > sb.Length)
            {
                throw new ArgumentOutOfRangeException("length", Extensions.LengthOutOfRangeErrorMessage);
            }

            StringBuilder result = new StringBuilder(length);

            for (int item = index; item < index + length; item++)
            {
                result.Append(sb[item]);
            }

            return result;
        }
    }
}