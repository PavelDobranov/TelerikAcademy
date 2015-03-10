namespace PhoneDevice
{
    using System;

    public class Battery
    {
        private const int HoursIdleDefaultValue = 0;
        private const int HoursTalkDefaultValue = 0;
        private const int ModelMinimumLenght = 2;
        private const string ModelNullOrEmptyErrorMessage = "Battery model cannot be null or empty";
        private const string ModelMinimumLengthErrorMessageFormat = "Battery model lenght must be at least {0} symbols";
        private const string HoursIdleLessThanZeroErrorMessageFormat = "Hours idle cannot be less than {0}";
        private const string HoursTalkLessThanZeroErrorMessageFormat = "Hours talk cannot be less than {0}";
        private const string ToStringFormat = "Model: {0}, Type: {1}, Hours idle: {2}, Hours talk: {3}";
        private const string InfoNotAvailable = "N/A";

        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model) : this(model, null, Battery.HoursIdleDefaultValue) { }

        public Battery(string model, BatteryType? type, int hoursIdle)
        {
            this.Model = model;
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = Battery.HoursTalkDefaultValue;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Battery.ModelNullOrEmptyErrorMessage);
                }

                if (value.Trim().Length < Battery.ModelMinimumLenght)
                {
                    throw new ArgumentException(string.Format(Battery.ModelMinimumLengthErrorMessageFormat, Battery.ModelMinimumLenght));
                }

                this.model = value;
            }
        }

        public BatteryType? Type { get; set; }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value < Battery.HoursTalkDefaultValue)
                {
                    throw new ArgumentException(string.Format(Battery.HoursTalkLessThanZeroErrorMessageFormat, Battery.HoursTalkDefaultValue));
                }

                this.hoursTalk = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value < Battery.HoursIdleDefaultValue)
                {
                    throw new ArgumentException(string.Format(Battery.HoursIdleLessThanZeroErrorMessageFormat, Battery.HoursIdleDefaultValue));
                }

                this.hoursIdle = value;
            }
        }

        public Battery ShallowCopy()
        {
            return this.MemberwiseClone() as Battery;
        }

        public override string ToString()
        {
            string typeToString = this.Type == null ? Battery.InfoNotAvailable : this.Type.ToString();

            return string.Format(Battery.ToStringFormat, this.Model, typeToString, this.HoursIdle, this.HoursTalk);
        }
    }
}