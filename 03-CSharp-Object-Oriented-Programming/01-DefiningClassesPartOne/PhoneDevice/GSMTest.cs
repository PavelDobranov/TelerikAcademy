namespace PhoneDevice
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        private List<GSM> testPhones;

        public GSMTest()
        {
            this.InitTestPhones();
        }

        public string GetPhonesInfo()
        {
            return string.Join(Environment.NewLine, this.testPhones);
        }

        private void InitTestPhones()
        {
            GSM nokia = new GSM("Lumia", "Nokia", 450, "Pesho", new Battery("AG49", BatteryType.LiIon, 150), new Display(3.5, 256));
            GSM samsung = new GSM("Galaxy", "Samsung");
            GSM htc = new GSM("One", "HTC");

            samsung.Owner = "Ivan";
            samsung.Price = 300;
            samsung.Battery = new Battery("Ah350", BatteryType.NiMH, 90);
            samsung.Display = new Display(6, 80000);

            this.testPhones = new List<GSM>();
            this.testPhones.Add(nokia);
            this.testPhones.Add(samsung);
            this.testPhones.Add(htc);
        }
    }
}