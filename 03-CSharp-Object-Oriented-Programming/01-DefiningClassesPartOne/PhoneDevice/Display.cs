namespace PhoneDevice
{
    using System;

    public class Display
    {
        private const double MinimumSize = 2.5;
        private const int MinimumColors = 2;
        private const string MinimumSizeErrorMessageFormat = "Display size cannot be less than {0} inches";
        private const string MinimumColorsErrorMessageFormat = "Display colors cannot be less than {0}";
        private const string ToStringFormat = "Size: {0}, Colors: {1}";
        private const string InfoNotAvailable = "N/A";

        private double? size;
        private int? numberOfColors;

        public Display() : this(null, null) { }

        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < Display.MinimumSize)
                {
                    throw new ArgumentException(string.Format(Display.MinimumSizeErrorMessageFormat, Display.MinimumSize));
                }

                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < Display.MinimumColors)
                {
                    throw new ArgumentException(string.Format(Display.MinimumColorsErrorMessageFormat, Display.MinimumColors));
                }

                this.numberOfColors = value;
            }
        }

        public Display ShallowCopy()
        {
            return this.MemberwiseClone() as Display;
        }

        public override string ToString()
        {
            string sizeToString = this.Size == null ? Display.InfoNotAvailable : this.Size.ToString();
            string numberOfColorsToString = this.NumberOfColors == null ? Display.InfoNotAvailable : this.NumberOfColors.ToString();

            return string.Format(Display.ToStringFormat, sizeToString, numberOfColorsToString);
        }
    }
}