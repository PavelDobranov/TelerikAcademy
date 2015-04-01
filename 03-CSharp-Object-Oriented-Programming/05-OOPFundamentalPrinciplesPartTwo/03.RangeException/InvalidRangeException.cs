namespace RangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message)
            : base(message)
        {
        }

        public InvalidRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidRangeException(string message, T rangeMin, T rangeMax)
            : this(message)
        {
            this.RangeMin = rangeMin;
            this.RangeMax = rangeMax;
        }

        public InvalidRangeException(string message, Exception innerException, T rangeMin, T rangeMax)
            : this(message, innerException)
        {
            this.RangeMin = rangeMin;
            this.RangeMax = rangeMax;
        }

        public T RangeMin { get; set; }

        public T RangeMax { get; set; }
    }
}