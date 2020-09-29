using MyFitTimer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class StopwatchTrackerData : IStopwatchTrackerData
    {
        public void DeleteResults()
        {
            throw new NotImplementedException();
        }

        // method for getting results 
        public Task<List<Results>> GetResults()
        {
            List<Results> timerRuns = new List<Results>();

            DateTime TempStartTime = DateTime.Now;

            Results firstRun = new Results()
            {
                StartTime = TempStartTime.AddHours(-1),
                EndTime = TempStartTime,
                TotalTime = new TimeSpan(TempStartTime.Ticks - TempStartTime.AddHours(-1).Ticks)
            };

            Results secondRun = new Results()
            {
                StartTime = TempStartTime.AddHours(-2).AddDays(-1),
                EndTime = TempStartTime.AddHours(-1).AddDays(-1).AddMinutes(10),
                TotalTime = new TimeSpan(TempStartTime.AddHours(-1).AddDays(-1).AddMinutes(10).Ticks - TempStartTime.AddHours(-2).AddDays(-1).Ticks)
            }; 

            timerRuns.Add(firstRun);
            timerRuns.Add(secondRun);

            return Task.FromResult(timerRuns);
        }

        // method for saving results
        public void SaveResults()
        {
            throw new NotImplementedException();
        }
    }
}
