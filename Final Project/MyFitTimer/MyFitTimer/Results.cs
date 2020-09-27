using System;

namespace MyFitTimer
{
    public class Results
    {
        public DateTime  StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}