namespace PhoneDevice
{
    using System;

    public class Call
    {
        private const int DurationMinValue = 0;
        private const string CallTimeNullOrEmptyErrorMessage = "Call time cannot be null or empty";
        private const string DailednumberNullOrEmptyErrorMessage = "Phone number cannot be null or empty";
        private const string DurationMinValueErrorMessageFormat = "Call duration cannot be less than {0} seconds";
        private const string ToStringFormat = "Date: {0}, Time: {1}, Dailed number: {2}, Duration: {3} sec.";

        private DateTime callTime;
        private string dailedNumber;
        private int duration;

        public Call(DateTime callTime, string dailedNumber, int duration)
        {
            this.CallTime = callTime;
            this.DailedNumber = dailedNumber;
            this.Duration = duration;
        }

        public DateTime CallTime
        {
            get
            {
                return this.callTime;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(Call.CallTimeNullOrEmptyErrorMessage);
                }

                this.callTime = value;
            }
        }

        public string DailedNumber
        {
            get
            {
                return this.dailedNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(Call.DailednumberNullOrEmptyErrorMessage);
                }

                this.dailedNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (value < Call.DurationMinValue)
                {
                    throw new ArgumentException(string.Format(Call.DurationMinValueErrorMessageFormat, Call.DurationMinValue));
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            string dateToString = this.callTime.ToString("dd.MM.yyyy");
            string timeToString = this.callTime.ToString("HH:mm");

            return string.Format(Call.ToStringFormat, dateToString, timeToString, this.DailedNumber, this.Duration);
        }
    }
}