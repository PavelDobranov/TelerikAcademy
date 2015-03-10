namespace PhoneDevice
{
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        private const string EmptyCallHistoryMessage = "Call history list is empty";
        private const decimal CallPricePerMinute = 0.37m;

        private GSM testPhone;

        public GSMCallHistoryTest()
        {
            this.InitTestPhone();
            this.initTestCalls();
        }

        public string GetCallInfo()
        {
            if (this.testPhone.CallHistory.Count == 0)
            {
                return GSMCallHistoryTest.EmptyCallHistoryMessage;
            }

            return string.Join(Environment.NewLine, this.testPhone.CallHistory);
        }

        public decimal GetTotalCallPrice()
        {
            return this.testPhone.CalculateTotalCallPrice(GSMCallHistoryTest.CallPricePerMinute);
        }

        public void RemoveLongestCall()
        {
            int longestCall = this.testPhone.CallHistory.Max(c => c.Duration);
            int longestCallIndex = this.testPhone.CallHistory.FindIndex(c => c.Duration == longestCall);

            this.testPhone.RemoveCall(longestCallIndex);
        }

        public void ClearCallHistory()
        {
            this.testPhone.ClearCallHistory();
        }

        private void InitTestPhone()
        {
            Battery testPhoneBattery = new Battery("AG49", BatteryType.LiIon, 150);
            Display testPhoneDisplay = new Display(3.5, 10000);

            this.testPhone = new GSM("Lumia", "Nokia", 450, "Pesho", testPhoneBattery, testPhoneDisplay);
        }

        private void initTestCalls()
        {
            DateTime now = DateTime.Now;

            this.testPhone.AddCall(new Call(now.AddMinutes(15), "+359887000000", 10));
            this.testPhone.AddCall(new Call(now.AddHours(10), "+359887111111", 130));
            this.testPhone.AddCall(new Call(now.AddDays(2), "+359887222222", 55));
        }
    }
}