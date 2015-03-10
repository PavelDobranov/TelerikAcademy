namespace PhoneDevice
{
    using System;

    public class PhoneDeviceMain
    {
        public static void Main()
        {
            RunGsmTest();
            RunGsmCallHistoryTest();
        }

        private static void RunGsmTest()
        {
            GSMTest gsmTest = new GSMTest();

            Console.WriteLine("------------");
            Console.WriteLine("[ GSM Test ]");
            Console.WriteLine("------------");
            Console.WriteLine(gsmTest.GetPhonesInfo());
            Console.WriteLine(GSM.IPhone4S);
        }

        private static void RunGsmCallHistoryTest()
        {
            GSMCallHistoryTest callHistoryTest = new GSMCallHistoryTest();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("[ GSM Call History Test - Full call history]");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(callHistoryTest.GetCallInfo());
            Console.WriteLine("Total call price: {0:F3}", callHistoryTest.GetTotalCallPrice());

            callHistoryTest.RemoveLongestCall();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("[ GSM Call History Test - Removed longest call]");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(callHistoryTest.GetCallInfo());
            Console.WriteLine("Total call price: {0:F3}", callHistoryTest.GetTotalCallPrice());

            callHistoryTest.ClearCallHistory();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("[ GSM Call History Test - Cleared call history]");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(callHistoryTest.GetCallInfo());
            Console.WriteLine("Total call price: {0:F3}", callHistoryTest.GetTotalCallPrice());
        }
    }
}