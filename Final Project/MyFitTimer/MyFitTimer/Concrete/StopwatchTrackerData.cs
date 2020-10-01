using MyFitTimer.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitTimer.Concrete
{
    public class StopwatchTrackerData : IStopwatchTrackerData
    {
        public void DeleteResults()
        {
            using (var db = new ResultsContext())
            {
                Console.WriteLine("Deleting the times");
                var times = db.Times
                    .OrderBy(b => b.StartTime);
                foreach(var time in times)
                {
                    db.Remove(time);
                }
                db.SaveChanges();
            }
        }

        // method for getting results 
        public Task<List<ResultsContext>> GetResults()
        {
            List<ResultsContext> timerRuns = new List<ResultsContext>();
            DateTime TempStartTime = DateTime.Now;
            using (var db = new ResultsContext())
            {   
                //read
                Console.WriteLine("Querying for times");
                var times = db.Times
                    .OrderBy(b => b.StartTime);

                foreach (var time in times)
                {
                    ResultsContext run = new ResultsContext();
                    Time timedItem = new Time();
                    timedItem.StartTime = time.StartTime;
                    timedItem.EndTime = time.EndTime;
                    timedItem.TotalTime = time.TotalTime;
                    run.Times.Add(timedItem);

                    timerRuns.Add(run);
                }
            }

            return Task.FromResult(timerRuns);
        }

        // method for saving results
        public void SaveResults(Stopwatch stopwatch)
        {
            using (var db = new ResultsContext())
            {
                //write
                var timeEntry = new Time { StartTime = DateTime.Now - stopwatch.Elapsed, EndTime = DateTime.Now, TotalTime = stopwatch.Elapsed };
                db.Add(timeEntry);
                db.SaveChanges();
            }
        }
    }
}
