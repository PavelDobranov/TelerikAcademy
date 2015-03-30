namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private const string LessOrEqualToZeroErrorMessageFormat = "{0} cannot be less or equal to zero";

        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Shape.ValidateSize(value, "Width");

                this.width = value;
            }
        }

        public double Height 
        {
            get
            {
                return this.height;
            }
            set
            {
                Shape.ValidateSize(value, "Height");

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        private static void ValidateSize(double value, string paramName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName, string.Format(Shape.LessOrEqualToZeroErrorMessageFormat, paramName));
            }
        }
    }
}