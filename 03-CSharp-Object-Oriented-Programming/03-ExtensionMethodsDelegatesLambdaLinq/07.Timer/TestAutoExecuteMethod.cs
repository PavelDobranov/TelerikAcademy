// Problem 7. Timer
// Using delegates write a class Timer that can execute certain method at each t seconds.

namespace AutoExecuteMethod
{
    using System;

    public class TestAutoExecuteMethod
    {
        public static void SomeMethod()
        {
            Console.WriteLine("Method to execute");
        }

        public static void Main()
        {
            Timer timer = new Timer();
            timer.someMethod = SomeMethod;

            int seconds = 1;
            int totalSeconds = 20;

            timer.Start(seconds, totalSeconds);
        }
    }
}