namespace PhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const int ModelMinimumLenght = 2;
        private const int ManufacturerMinimumLenght = 2;
        private const int MinimumPrice = 0;
        private const int OwnerMinimumLenght = 3;
        private const string ModelNullOrEmptyErrorMessage = "Phone model cannot be null or empty";
        private const string ModelMinimumLengthErrorMessageFormat = "Phone model lenght must be at least {0} symbols";
        private const string ManufacturerNullOrEmptyErrorMessage = "Phone manufacturer cannot be null or empty";
        private const string ManufacturerMinimumLengthErrorMessageFormat = "Phone manufacturer lenght must be at least {0} symbols";
        private const string MinimumPriceErrorMessageFormat = "Phone price cannot be less than {0}";
        private const string OwnerMinimumLengthErrorMessageFormat = "Phone owner lenght must be at least {0} symbols";
        private const string ModelToStringFormat = "Model: {0}";
        private const string ManufacturerToStringFormat = "Manufacturer: {0}";
        private const string PriceToStringFormat = "Price: {0}";
        private const string OwnerToStringFormat = "Owner: {0}";
        private const string BatteryToStringFormat = "Battery: {0}";
        private const string DisplayToStringFormat = "Display: {0}";
        private const string InfoNotAvailable = "N/A";
        private const string IPhone4SModel = "4S";
        private const string IPhone4SManufacturer = "Apple";
        private const decimal IPhone4SPrice = 900;
        private const string IPhone4SOwner = "Stoyan";
        private const string IPhone4SBatteryModel = "GH125";
        private const BatteryType IPhone4SBatteryType = BatteryType.LiIon;
        private const int IPhone4SHoursIdle = 300;
        private const int IPhone4SDisplaySize = 5;
        private const int IPhone4SDisplayColors = 10000;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        private static GSM iPhone4S = new GSM(
           GSM.IPhone4SModel,
           GSM.IPhone4SManufacturer,
           GSM.IPhone4SPrice,
           GSM.IPhone4SOwner,
           new Battery(GSM.IPhone4SBatteryModel, GSM.IPhone4SBatteryType, GSM.IPhone4SHoursIdle),
           new Display(GSM.IPhone4SDisplaySize, GSM.IPhone4SDisplayColors));

        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null) { }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
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
                    throw new ArgumentException(GSM.ModelNullOrEmptyErrorMessage);
                }

                if (value.Trim().Length < GSM.ModelMinimumLenght)
                {
                    throw new ArgumentException(string.Format(GSM.ModelMinimumLengthErrorMessageFormat, GSM.ModelMinimumLenght));
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException(GSM.ManufacturerNullOrEmptyErrorMessage);
                }

                if (value.Trim().Length < GSM.ManufacturerMinimumLenght)
                {
                    throw new ArgumentException(string.Format(GSM.ManufacturerMinimumLengthErrorMessageFormat, GSM.ManufacturerMinimumLenght));
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < GSM.MinimumPrice)
                {
                    throw new ArgumentException(string.Format(GSM.MinimumPriceErrorMessageFormat, GSM.MinimumPrice));
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != null && value.Trim().Length < GSM.OwnerMinimumLenght)
                {
                    throw new ArgumentException(string.Format(GSM.OwnerMinimumLengthErrorMessageFormat, GSM.OwnerMinimumLenght));
                }

                this.owner = value;
            }

        }

        public Battery Battery
        {
            get
            {
                return this.battery == null ? null : this.battery.ShallowCopy();
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display == null ? null : this.display.ShallowCopy();
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return GSM.iPhone4S;
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;

            foreach (var call in callHistory)
            {
                double minutes = TimeSpan.FromSeconds(call.Duration).TotalMinutes;
                totalPrice += (decimal)minutes * pricePerMinute;
            }

            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string priceToString = this.Price == null ? GSM.InfoNotAvailable : this.Price.ToString();
            string ownerToString = this.Owner == null ? GSM.InfoNotAvailable : this.Owner;
            string batteryToString = this.Battery == null ? GSM.InfoNotAvailable : this.Battery.ToString();
            string displayToString = this.Display == null ? GSM.InfoNotAvailable : this.Display.ToString();

            result.AppendLine(string.Format(GSM.ModelToStringFormat, this.Model));
            result.AppendLine(string.Format(GSM.ManufacturerToStringFormat, this.Manufacturer));
            result.AppendLine(string.Format(GSM.PriceToStringFormat, priceToString));
            result.AppendLine(string.Format(GSM.OwnerToStringFormat, ownerToString));
            result.AppendLine(string.Format(GSM.BatteryToStringFormat, batteryToString));
            result.AppendLine(string.Format(GSM.DisplayToStringFormat, displayToString));

            return result.ToString();
        }
    }
}