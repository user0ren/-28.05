using System;

namespace Test_try
{
    public class Class1
    {
        public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations,
            TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            int duration = 0;
            foreach (int i in durations)
                duration += i;

            TimeSpan consultationTimeSpan = new TimeSpan(0, consultationTime, 0);
            int pusto = 0;
            for (int i = 1; i < startTimes.Length; i++)
            {
                TimeSpan durationTimeSpan = new TimeSpan(0, durations[i], 0);
                if (startTimes[i] - (startTimes[i - 1] + durationTimeSpan) < consultationTimeSpan)
                    pusto += 1;
            }

            int nomer = 0;
            int dlina = (endWorkingTime.Hours*60 + endWorkingTime.Minutes - beginWorkingTime.Hours * 60 + 
                beginWorkingTime.Minutes - duration) / consultationTime - pusto;
            string[] str = new string[dlina];

            TimeSpan now = beginWorkingTime;
            TimeSpan now_1 = new TimeSpan(now.Hours, now.Minutes + consultationTime, now.Seconds);

            for (int i = 0; now < endWorkingTime; i++)
            {
                if (nomer <= startTimes.Length - 1 && now > (startTimes[nomer] - consultationTimeSpan))
                {
                    now_1 = new TimeSpan(startTimes[nomer].Hours, startTimes[nomer].Minutes + durations[nomer], startTimes[nomer].Seconds);
                    nomer += 1;
                }
                else
                {
                    str[i - nomer] = now.ToString() + " - " + now_1.ToString();
                }                
                now = now_1;
                now_1 = new TimeSpan(now.Hours,  now.Minutes + consultationTime, now.Seconds);
            }

            return str;
        }
    }
}