using System;

namespace Test_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            TimeSpan[] startTimes = 
                { 
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
                };


            int[] durations = { 60, 30, 10, 10, 40 };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
            int consultationTime = 30;

            string[] str = Class1.AvailablePeriods(startTimes, durations, beginWorkingTime,
                endWorkingTime, consultationTime);

            Console.WriteLine("Str:");
            foreach (string i in str)
                Console.WriteLine(i);
        }
    }
}
