namespace AutoExecuteMethod
{
    using System;
    using System.Threading;

    public delegate void MethodToExecute();

    public class Timer
    {
        public MethodToExecute someMethod;

        public void Start(int seconds, int totalSeconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(totalSeconds);

            while (startTime <= endTime)
            {
                someMethod();
                Thread.Sleep(seconds * 1000);
                startTime = DateTime.Now;
            }
        }
    }
}